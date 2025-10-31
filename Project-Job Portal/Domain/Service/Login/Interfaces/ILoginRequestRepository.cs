using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.Login.Interfaces
{
    public interface ILoginRequestRepository
    {
        Task<AuthUser?> GetUserByEmailAsync(string email);
       Task<AuthUser?> GetUserByEmailAndPasswordAsync(string email, string password);
    }
}
