using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Exceptions
{
    internal class InvalidAmountException:ApplicationException
    {
        public InvalidAmountException() { }

        public InvalidAmountException(string message) : base(message) { }
    }
}
