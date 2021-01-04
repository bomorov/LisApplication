using Application.Common.Models;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IRefreshTokenService
    {
        Task<(Result, string)> GenerateRToken(int userId);

        Task<(Result, string)> RefreshToken(int userId, string refreshToken);

        Task StopRefreshToken(int userId);
    }
}