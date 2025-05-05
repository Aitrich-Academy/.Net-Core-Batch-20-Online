using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetails
{
    public class IdException : ApplicationException
    {
        public IdException() 
        {
            Console.WriteLine("Invalid ID format");
        }
        public IdException(string message) 
        {
            Console.WriteLine("Id should contain only digits");
        }
    }
}
