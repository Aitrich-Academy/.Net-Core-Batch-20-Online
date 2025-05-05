using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationActivity1Exception.VlidationException
{
    internal class NameException:ApplicationException
    {
        public NameException() 
        {
            Console.WriteLine("An exception found while validating name ");
        }
        public NameException(string message):base(message)
        {
            Console.WriteLine("use only Alphabets");
        }
    }
}
