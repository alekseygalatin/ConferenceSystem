using System.Threading.Tasks;
using ConferenceSystem.Application.JwtSettings;
using ConferenceSystem.Models;

namespace ConferenceSystem.Services
{
    public interface ITokenService
    {
        string CreateToken(User user);
        JwtRefreshToken GenerateRefreshToken(User user);
        Task<JwtRefreshToken> GetRefreshTokenAsync(int userId, string refreshToken);
        int GetUserIdFromExpiredToken(string token);
        Task AddRefreshTokenAsync(JwtRefreshToken jwtRefreshToken);
        Task RemoveRefreshTokenAsync(JwtRefreshToken jwtRefreshToken);
    }
}
