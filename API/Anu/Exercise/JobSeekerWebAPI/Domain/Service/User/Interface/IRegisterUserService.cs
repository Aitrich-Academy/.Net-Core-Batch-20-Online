using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.User.DTO;

namespace Domain.Service.User.Interface
{
    public interface IRegisterUserService

    {
        Task<RegisterUserDto> AddRegisterUserAsync(RegisterUserDto  ReguserDto);
        
    }
        
}

