using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountException.Exceptions
{
    internal class Validatewithdrawal : Exception
    {
        public Validatewithdrawal(string message) : base (message) { }
    }
}
