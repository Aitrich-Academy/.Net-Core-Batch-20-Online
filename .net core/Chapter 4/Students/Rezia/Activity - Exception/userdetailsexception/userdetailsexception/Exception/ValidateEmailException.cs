using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userdetailsexception.Exception
{
    public class ValidateEmailException : ApplicationException
    {
        public ValidateEmailException(string message) : base (message) { 
        Console.WriteLine(message);
        }
    }
}
