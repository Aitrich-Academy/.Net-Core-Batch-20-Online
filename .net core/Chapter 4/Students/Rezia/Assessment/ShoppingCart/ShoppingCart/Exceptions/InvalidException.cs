using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Exceptions
{
    internal class InvalidException
    {
        public InvalidException( string message)
        { 
        throw new InvalidOperationException(message);
        }
    }
}
