using CompanyManagement.Model;

namespace CompanyManagement.Interface
{
    public interface IUserRepository
    {
        Task<User> GetByUsernameAsync(string username);
        Task<User> GetByIdAsync(int id);
        Task<bool> AddUserAsync(User user);
        Task<User> ValidateUserAsync(string username, string password);
    }
}
