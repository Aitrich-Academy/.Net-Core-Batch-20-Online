using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewExcersice.Model;

namespace NewExcersice.Interfaces
{
    public interface IUserRepository
    {
        User Login(string email, string password);
        void Register(User user);
    }
}
