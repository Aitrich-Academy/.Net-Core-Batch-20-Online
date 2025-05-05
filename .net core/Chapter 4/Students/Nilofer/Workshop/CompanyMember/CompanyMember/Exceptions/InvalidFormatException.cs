using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMember.Exceptions
{
    internal class InvalidFormatException:ApplicationException
    {
        public InvalidFormatException() { }

        public InvalidFormatException(string message) : base(message) { }
    }
}
