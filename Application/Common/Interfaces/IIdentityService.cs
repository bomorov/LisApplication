using Application.Common.DTOs;
using Application.Common.Models;
using Domain.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<Result> LoginAsync(string email, string password, bool rememberMe);

        Task LogoutAsync();

        Task<(Result, ApiUserToken)> Authenticate(string username, string password);

        Task<(Result, ApiUserToken)> RefreshToken(string userRefreshToken);

        Task ApiSignOutAsync(int userId);

        Task<(Result result, int userId)> CreateUserAsync(ApplicationUser user, string password);

        Task<Result> UpdateUserAsync(ApplicationUser user);

        Task<IList<ApplicationUser>> GetUsersAsync();

        Task<ApplicationUser> GetUser(int id);

        Task ResetPassword(int userId);

        Task<Result> ChangePassword(ChangePasswordDto dto);

        Task<string> GetUserFullName(int Id);

        Task<bool> IsNotUniqueUserPIN(string pin);
    }
}