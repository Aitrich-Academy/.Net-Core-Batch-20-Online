using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class TypeException :ApplicationException
    {
        public TypeException() { Console.WriteLine("Account type Error"); }
        public TypeException(string message) : base(message)
        {
            Console.WriteLine("Account type should be  Savings / Current");
        }
    }
}
