using AutoMapper;
using Hangfire.MemoryStorage.Dto;
using JobPortal.Dto;
using JobPortal.Interface;
using JobPortal.Model;
using JobPortal.Repository;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Service
{
    public class UserService :IUserService 
    {
        private readonly UserRepository userRepository;

        public UserService(UserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        public async Task AddUserAsync(UserDto userDto)
        {
            await userRepository.AddUserAsync(userDto);
        }
    }
}
