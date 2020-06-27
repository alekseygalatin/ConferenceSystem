using System.Threading.Tasks;
using ConferenceSystem.Models;

namespace ConferenceSystem.Services
{
    public interface IUserService
    {
        Task<User> GetAsync(string userEmail);
        Task<User> GetAsync(int userId);
        Task<User> AddAsync(CreateUserDto createUserDto);
        bool ValidatePassword(User user, string password);
    }
}
