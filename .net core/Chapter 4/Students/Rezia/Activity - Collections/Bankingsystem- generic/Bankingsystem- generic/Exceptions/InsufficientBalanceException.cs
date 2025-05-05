using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankingsystem__generic.Exceptions
{
    internal class InsufficientBalanceException : ApplicationException
    {
        public InsufficientBalanceException() { }

        public InsufficientBalanceException(string message) : base(message) { }
    }
}
