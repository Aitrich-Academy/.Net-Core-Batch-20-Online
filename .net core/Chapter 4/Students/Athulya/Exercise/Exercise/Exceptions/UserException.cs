using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exceptions
{
    public class UserException:Exception
    {
        public UserException() { }

        public UserException(string email) : base(String.Format("User Already Exist with this email ", email)) { }

    }
}
