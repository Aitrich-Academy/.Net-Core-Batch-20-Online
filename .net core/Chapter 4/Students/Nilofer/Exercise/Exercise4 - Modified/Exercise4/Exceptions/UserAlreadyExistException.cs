using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4.Exceptions
{
    internal class UserAlreadyExistException:ApplicationException
    {
        public UserAlreadyExistException() { }

        public UserAlreadyExistException(string message) : base(message) { }

       
    }
}
