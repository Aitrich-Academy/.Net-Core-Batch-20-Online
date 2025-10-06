using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.Authuser.Interface
{
    public interface IAuthUserRepository
    {
        string? CreateToken(AuthUser user);
    }
}
