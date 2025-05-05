using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Exceptions
{
    public class NameException : ApplicationException
    {
        public NameException()
        {
            Console.WriteLine("Other than alphabets.. other values can not accept");
        }
        public NameException(string message) : base(message)
        {
            Console.WriteLine("Product name only contain string values");
        }
    }
}
