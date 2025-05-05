using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetails
{
    public class NameException : ApplicationException
    {
        public NameException() 
        {
            Console.WriteLine("An exception found while validating name");
        }
        public NameException(string message) : base(message)
        {
            Console.WriteLine("Name must contain only Aphabets(a-z/ A-Z)");
        }
    }
}
