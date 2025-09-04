using JobPortalAPI.Models;

namespace JobPortalAPI.Interface
{
    public interface IUserRepository
    {
        Task<User> RegisterUserAsync(User user);
        Task<User> GetUserByEmailAsync(string email);

        Task<User> GetUserByIdAsync(int id);
    }
}
