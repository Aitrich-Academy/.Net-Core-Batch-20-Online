using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emailexception.Exception
{
    public class ValidateEmail : ApplicationException
    {
        public ValidateEmail() {
            Console.WriteLine("Exception");
        }
        public ValidateEmail(string message) : base(message)
        {
            Console.WriteLine(message);
        }

    }
}
