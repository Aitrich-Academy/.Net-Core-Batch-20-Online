using SimpleAuthMVC.Models;

namespace SimpleAuthMVC.Interface
{
    public interface  IUserRepository
    {
        Task AddUserAsync(User user);

        Task<User> GetUserByEmailAsync(string email);
    }
}
