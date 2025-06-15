using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExcersice.Exceptions
{
    public class UserAlreadyExistsException : System.Exception
    {
        public UserAlreadyExistsException(string message) : base(message) { }
    }
}
