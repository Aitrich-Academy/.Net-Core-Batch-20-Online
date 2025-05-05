using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class AccountNotFoundException:ApplicationException
    {
        public AccountNotFoundException(string message) : base(message) { }

        public AccountNotFoundException() { }


    }
}
