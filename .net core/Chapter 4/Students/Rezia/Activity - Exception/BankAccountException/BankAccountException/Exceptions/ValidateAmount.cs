using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountException.Exceptions
{
    internal class ValidateAmount : Exception
    {
        public ValidateAmount(string message) : base (message){ }
    }
}
