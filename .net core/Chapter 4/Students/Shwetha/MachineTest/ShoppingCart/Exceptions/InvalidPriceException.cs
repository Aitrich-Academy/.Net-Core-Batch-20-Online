using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Exceptions
{
    public class InvalidPriceException : ApplicationException
    {
        public InvalidPriceException()
        {
            Console.WriteLine("Number below or eqal 0 is not acceptable");
        }
        public InvalidPriceException(string message) : base(message)
        {
            Console.WriteLine("Number below or eqal 0 is not acceptable");
        }
    }
}
