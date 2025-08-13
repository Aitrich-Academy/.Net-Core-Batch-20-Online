using JobApi.Model;
using JobPortalAPI.DTOs;

namespace JobApi.Interface
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmailAsync(string email);
        Task<User> RegisterUserAsync(User user);
        Task<User> GetUserByIdAsync(int id);
    }
}
