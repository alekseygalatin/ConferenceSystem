using ConferenceSystem.Application.JwtSettings;
using ConferenceSystem.Models;
using System.Threading.Tasks;

namespace ConferenceSystem.Application.Auth
{
    public interface IAuthenticationManager
    {
        Task<JwtToken> Authenticate(LoginDto loginDto);
        Task<User> GetCurrentUser();
        Task<JwtToken> RegisterAsync(CreateUserDto createUserDto);
        Task<JwtToken> RefreshToken(JwtToken jwtToken);
    }
}
