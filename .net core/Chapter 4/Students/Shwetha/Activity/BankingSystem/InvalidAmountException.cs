using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class InvalidAmountException : ApplicationException
    {
        public InvalidAmountException()
        {
            Console.WriteLine("Error occured in Amount .  ");
        }
        public InvalidAmountException(string message) : base(message)
        {
            Console.WriteLine("Amount must contain only digits . ");
        }
    }
}
