using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using Domain.Service.Login.DTO;
=======
using Domain.Service.Login.DTOs;
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341

namespace Domain.Service.Login.Interfaces
{
    public interface ILoginRequestService
    {
<<<<<<< HEAD
        JobProviderLoginDto Login(string email, string password);
=======
        Task<JobSeekerLoginDto?> LoginJS(string email, string password);
>>>>>>> a4a742265a37d480c4305bd8081a8bd2d21d9341
    }
}