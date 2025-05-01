using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Interfaces
{
    public interface ILogin
    {
        bool Login(string email, string password);
    }
}
