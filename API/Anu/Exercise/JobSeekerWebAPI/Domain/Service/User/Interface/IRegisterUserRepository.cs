using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.User.Interface
{
    public interface IRegisterUserRepository
    {
        Task<RegisterUser> AddRegisterUserAsync(RegisterUser Reguser);
        Task<RegisterUser> GetUserByEmailAsync(string email);


    }
}
