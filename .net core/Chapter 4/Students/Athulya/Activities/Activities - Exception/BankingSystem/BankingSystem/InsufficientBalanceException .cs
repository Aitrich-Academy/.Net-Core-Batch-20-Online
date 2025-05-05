using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class InsufficientBalanceException:ApplicationException
    {

        public InsufficientBalanceException(string message) : base(message) { }

        public InsufficientBalanceException() { }
    }
}

