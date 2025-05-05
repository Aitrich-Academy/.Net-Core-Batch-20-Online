using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Exceptions
{
    public class IdNotFoundException : ApplicationException
    {
        public IdNotFoundException()
        {
            Console.WriteLine("Id which you given is not available in the list");
        }
        public IdNotFoundException(string message) : base(message)
        {
            Console.WriteLine("Id which you given is not available in the list");
        }
    }
}
