using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.Login.Dto;

namespace Domain.Service.Login.Interface
{
    public interface ILoginRequestService
    {
        AdminLoginDto Adminlogin(string email, string password);
    }
}
