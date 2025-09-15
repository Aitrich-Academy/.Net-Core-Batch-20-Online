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
    public interface IUserService

    {
        Task<UserDto> AddRegisterAsync(UserDto userdto);

        //Task<UserDto> LoginUserAsync(LoginDto userLoginDto);
        Task<(string Token, User User)?> LoginUserAsync(LoginDto loginDto);

    }
}
