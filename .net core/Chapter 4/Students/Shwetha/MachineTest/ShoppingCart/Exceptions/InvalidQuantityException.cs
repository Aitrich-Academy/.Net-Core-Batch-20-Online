using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Exceptions 
{
    public class InvalidQuantityException : ApplicationException
    {
        public InvalidQuantityException()
        {
            Console.WriteLine("This must be a non zero value");
        }
        public InvalidQuantityException(string message) : base(message)
        {
            Console.WriteLine("This must be a non zero value");
        }
    }
}
