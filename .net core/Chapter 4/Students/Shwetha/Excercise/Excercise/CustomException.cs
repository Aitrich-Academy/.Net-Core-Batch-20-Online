using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    internal class CustomException : ApplicationException
    {
        public CustomException() { }
        public CustomException(string message) : base(message)
        {
            Console.WriteLine("Exception occured...Please try again..!");
        }
    }
}
