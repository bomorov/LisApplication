using Application.Common.DTOs;
using Application.Common.Interfaces;
using Application.Common.Models;
using Application.Identity;
using Domain.Enums;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IRefreshTokenService _refreshTokenService;
        private readonly IHttpContextUserService _contextUserService;
        private readonly JwtSettings _jwtSettings;

        public IdentityService
            (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager,
            IRefreshTokenService refreshTokenService, IOptions<JwtSettings> options, IHttpContextUserService contextUserService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _refreshTokenService = refreshTokenService;
            _jwtSettings = options.Value;
            _contextUserService = contextUserService;
        }

        public async Task<Result> LoginAsync(string username, string password, bool rememberMe)
        {
            var user = await _userManager.Users
                    .Include(c => c.UserRoles).ThenInclude(c => c.Role)
                    .SingleOrDefaultAsync(x => x.UserName == username);

            if (user == null)
                return Result.Failure("Неправильный логин или пароль.");

            if (user.FairDate.HasValue)
                return Result.Failure("Данный сотрудник уволен.");

            var result = await _signInManager.PasswordSignInAsync(username, password, rememberMe, false);

            if (!result.Succeeded)
                return Result.Failure("Неправильный логин или пароль.");

            return Result.Success();
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<(Result, ApiUserToken)> Authenticate(string username, string password)
        {
            var user = await _userManager.Users
                .Include(c => c.UserRoles).ThenInclude(c => c.Role)
                .SingleOrDefaultAsync(x => x.UserName == username);

            if (user == null)
                return (Result.Failure("Неправильный логин или пароль!"), null);

            var result = await _signInManager.PasswordSignInAsync(username, password, false, false);
            if (result.Succeeded)
            {
                List<Claim> claims = CreateUserClaims(user);
                ApiUserToken token = new ApiUserToken();

                var (rtResult, rtToken) = await _refreshTokenService.GenerateRToken(user.Id);
                if (!rtResult.Succeeded)
                    return (rtResult, null);

                token.RtToken = rtToken;
                token.JwtToken = GenerateJSONWebToken(claims);

                return (Result.Success(), token);
            }

            return (Result.Failure("Неправильный логин или пароль!"), null);
        }

        public async Task<(Result, ApiUserToken)> RefreshToken(string userRefreshToken)
        {
            int currentUserId = _contextUserService.UserId;

            var (rtResult, rtToken) = await _refreshTokenService.RefreshToken(currentUserId, userRefreshToken);

            if (!rtResult.Succeeded)
                return (rtResult, null);

            var user = await _userManager.Users.Include(c => c.UserRoles).ThenInclude(c => c.Role)
                .SingleOrDefaultAsync(u => u.Id == currentUserId);

            List<Claim> claims = CreateUserClaims(user);

            var token = new ApiUserToken
            {
                JwtToken = GenerateJSONWebToken(claims),
                RtToken = rtToken
            };

            return (Result.Success(), token);
        }

        private List<Claim> CreateUserClaims(ApplicationUser user)
        {
            return new List<Claim> {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(CustomClaimTypes.PIN, user.Pin),
                new Claim(CustomClaimTypes.FullName, $"{user.LastName} {user.FirstName} {user.Patronymic}"),
                new Claim(CustomClaimTypes.FirstName, user.FirstName),
                new Claim(CustomClaimTypes.LastName, user.LastName),
                new Claim(CustomClaimTypes.PhoneNumber, user.PhoneNumber ?? "")
            };
        }

        private string GenerateJSONWebToken(List<Claim> claims)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Issuer = _jwtSettings.Issuer,
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(3),
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        public async Task ApiSignOutAsync(int userId)
        {
            await _signInManager.SignOutAsync();
            await _refreshTokenService.StopRefreshToken(userId);
        }

        public async Task<(Result result, int userId)> CreateUserAsync(ApplicationUser user, string password)
        {
            var result = await _userManager.CreateAsync(user, password);

            return (result.ToApplicationResult(), user.Id);
        }

        public async Task<Result> UpdateUserAsync(ApplicationUser user)
        {
            var result = await _userManager.UpdateAsync(user);

            return result.ToApplicationResult();
        }

        public async Task<IList<ApplicationUser>> GetUsersAsync()
        {
            return await _userManager.Users.AsNoTracking()
                .Where(x => !x.IsRoot).ToListAsync();
        }

        public Task<ApplicationUser> GetUser(int id)
        {
            return _userManager.Users.Include(u => u.UserRoles).SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task ResetPassword(int userId)
        {
            var user = await _userManager.Users.FirstAsync(x => x.Id == userId);
            await _userManager.RemovePasswordAsync(user);
            await _userManager.AddPasswordAsync(user, "Qwerty123");
        }

        public async Task<Result> ChangePassword(ChangePasswordDto dto)
        {
            var user = await _userManager.Users.Include(c => c.UserRoles).ThenInclude(c => c.Role)
                .SingleOrDefaultAsync(x => x.Id == dto.UserId);
            if (user == null)
                return Result.Failure("Пользователь не найден.");
            var result = await _userManager.ChangePasswordAsync(user, dto.OldPassword, dto.Password);
            return result.ToApplicationResult();
        }

        public async Task<string> GetUserFullName(int Id)
        {
            var user = await _userManager.FindByIdAsync(Id.ToString());
            if (user == null)
            {
                return "Системный пользователь";
            }
            return $"{user.LastName} {user.FirstName} {user.Patronymic}";
        }

        public async Task<bool> IsNotUniqueUserPIN(string pin)
        {
            return await _userManager.Users.AnyAsync(x => x.Pin == pin);
        }
    }
}