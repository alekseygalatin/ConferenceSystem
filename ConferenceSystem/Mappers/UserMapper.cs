using ConferenceSystem.Models;

namespace ConferenceSystem.Mappers
{
    public static class UserMapper
    {
        public static UserViewModel Map(User user)
        {
            return new UserViewModel
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }
    }
}
