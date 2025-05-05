using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProvider.Exceptions
{
    internal class UserAlreadyExitsException : Exception
    {
        public UserAlreadyExitsException() { }
        public UserAlreadyExitsException(string email) : base(String.Format("User already exist in this email ", email))
            { }
        
    }
}
