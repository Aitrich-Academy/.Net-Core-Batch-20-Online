using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProvider.Exceptions
{
    internal class InvalidFormatExceptions : Exception
    {
        public InvalidFormatExceptions() { }
        public InvalidFormatExceptions(string message) : base (message)
        { 
         
        }
    }
}
