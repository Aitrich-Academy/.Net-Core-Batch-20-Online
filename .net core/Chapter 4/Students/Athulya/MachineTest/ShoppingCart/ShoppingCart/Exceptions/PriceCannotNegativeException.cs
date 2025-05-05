using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Exceptions
{
    public class PriceCannotNegativeException : Exception
    {
        public PriceCannotNegativeException() { }
        public PriceCannotNegativeException(string message) : base(message)
        {
        }
    }
}
