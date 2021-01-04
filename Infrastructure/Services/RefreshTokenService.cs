using Application.Common.Interfaces;
using Application.Common.Models;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class RefreshTokenService : IRefreshTokenService
    {
        private readonly IApplicationDbContext _context;

        public RefreshTokenService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<(Result, string)> GenerateRToken(int userId)
        {
            var refresh_token = Guid.NewGuid().ToString().Replace("-", "");

            var rToken = new RToken
            {
                UserId = userId,
                RefreshToken = refresh_token,
                IsStop = false
            };

            _context.RTokens.Add(rToken);
            await _context.SaveChangesAsync(new CancellationToken());

            return (Result.Success(), refresh_token);
        }

        public async Task<(Result, string)> RefreshToken(int userId, string refreshToken)
        {
            var rToken = await _context.RTokens.FirstOrDefaultAsync(rt => rt.UserId == userId && rt.RefreshToken == refreshToken);

            if (rToken == null)
                return (Result.Failure("Can't find refresh token"), null);

            if (rToken.IsStop)
                return (Result.Failure("Refresh token has expired"), null);

            await _context.BeginTransactionAsync();

            rToken.IsStop = true;

            _context.RTokens.Update(rToken);

            var newRefreshToken = Guid.NewGuid().ToString().Replace("-", "");

            _context.RTokens.Add(new RToken
            {
                UserId = userId,
                RefreshToken = newRefreshToken,
                IsStop = false
            });

            await _context.CommitTransactionAsync();

            return (Result.Success(), newRefreshToken);
        }

        public async Task StopRefreshToken(int userId)
        {
            var rToken = await _context.RTokens.FirstOrDefaultAsync(rt => rt.UserId == userId && !rt.IsStop);

            rToken.IsStop = true;

            _context.RTokens.Update(rToken);
            await _context.SaveChangesAsync(new CancellationToken());
        }
    }
}