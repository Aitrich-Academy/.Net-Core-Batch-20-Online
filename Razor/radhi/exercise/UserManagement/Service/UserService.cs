using UserManagement.Interface;
using UserManagement.Dto;
using UserManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UserManagement.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            return await userRepository.GetAllUserAsync();
        }

        public async Task AddUserAsync(UserDto userDto)
        {
            var user = new User
            {
                UserName = userDto.UserName,
                Email = userDto.Email,
                Password = userDto.Password
            };

            await userRepository.AddUserAsync(userDto);
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await userRepository.GetUserByIdAsync(id);
        }
        public async Task<User> GetUserByUsernameAsync(string username)
        {
            return await userRepository.GetUserByUsernameAsync(username);
        }

    }
}
