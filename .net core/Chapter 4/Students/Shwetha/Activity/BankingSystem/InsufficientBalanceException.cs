using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class InsufficientBalanceException : ApplicationException
    {
        public InsufficientBalanceException() 
        {
            Console.WriteLine("There does not exist sufficient balance"); 
        }
        public InsufficientBalanceException(string message) : base(message)
        {
            Console.WriteLine("There does not exist sufficient balance");
        }

    }
}
