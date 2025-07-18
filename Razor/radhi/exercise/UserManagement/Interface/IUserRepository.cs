using Microsoft.AspNetCore.Mvc;
using UserManagement.Dto;
using UserManagement.Models;

namespace UserManagement.Interface
{
    public interface IUserRepository
    {
        public Task<List<User>> GetAllUserAsync();
        Task<User> GetUserByIdAsync(int id);
        public Task AddUserAsync(UserDto UserDto);
        Task<User> GetUserByUsernameAsync(string username);



    }
}
