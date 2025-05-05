using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Exceptions
{
    public class RemoveNonExistingItemException : ApplicationException
    {
        public RemoveNonExistingItemException()
        {
            Console.WriteLine("You are trying to remove item from this cart which is not present in the list");
        }
        public RemoveNonExistingItemException(string message)
        {
            Console.WriteLine("You are trying to remove item from this cart which is not present in the list");
        }
    }
}
