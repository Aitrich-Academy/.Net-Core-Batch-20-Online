using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobportal.Exceptions
{
    public class UserAlreadyexist : Exception
    {
        public UserAlreadyexist() { }

        public UserAlreadyexist(string email) : base(String.Format($"User already exist with this email:{email}"))
        {

        }

    }
}
