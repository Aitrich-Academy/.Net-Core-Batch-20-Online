using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemwithList.Exceptions
{
    public class AccountNotFoundException:ApplicationException 

    {
        public AccountNotFoundException() { }

        public AccountNotFoundException(string message) : base(message) { }
    }
}
