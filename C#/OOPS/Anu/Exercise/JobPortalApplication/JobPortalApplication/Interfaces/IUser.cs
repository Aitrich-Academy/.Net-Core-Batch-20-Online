using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortalApplication.Models;

namespace JobPortalApplication.Interfaces
{
    public interface IUser
    {
        void Register(User user);
        User Login(string email, string password);
    }
}
