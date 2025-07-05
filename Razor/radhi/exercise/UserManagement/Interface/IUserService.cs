using Microsoft.AspNetCore.Mvc;
using UserManagement.Dto;
using UserManagement.Models;
using UserManagement.Repository;

namespace UserManagement.Interface
{
    public interface IUserService
    {
        public Task<List<User>> GetAllUserAsync();
        Task<User> GetUserByIdAsync(int id);
        public Task AddUserAsync(UserDto UserDto);
        Task<User> GetUserByUsernameAsync(string username);


    }
}
