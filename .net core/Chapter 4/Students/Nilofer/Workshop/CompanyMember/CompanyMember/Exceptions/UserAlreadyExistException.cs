using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMember.Exceptions
{
    internal class UserAlreadyExistException:ApplicationException
    {
        public UserAlreadyExistException() { }

        public UserAlreadyExistException(string email)
           : base(String.Format("User Already Exist with this email ", email))
        {

        }
    }
}
