using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Domain.Dto;

namespace Domain.Interface
{
    public interface IUserRepository
    {
        Task<User> AddRegisterAsync(User user);
        Task<User> GetUserByEmailAsync(string email);

        Task<User> GetUserByEmailAndPasswordAsync(string email, string password);

       // Task<User> LoginUserAsync(LoginDto userLoginDto);
    }
}
