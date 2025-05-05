using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4.Exceptions
{
    internal class InvalidEmailException:ApplicationException
    {
        public InvalidEmailException() { }

        public InvalidEmailException(string message) : base(message) { }
    }
}
