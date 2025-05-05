using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userdetailsexception.Exception
{
   public class ValidatephoneException : ApplicationException
    {
        public ValidatephoneException(string message) : base (message) {
        Console.WriteLine (message);
        }
    }
}
