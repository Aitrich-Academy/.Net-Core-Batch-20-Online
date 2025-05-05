using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemwithList.Exceptions
{
    internal class InvalidAmountException:ApplicationException
    {
        public InvalidAmountException(string message) : base(message) { }

        public InvalidAmountException() { }
    }
}
