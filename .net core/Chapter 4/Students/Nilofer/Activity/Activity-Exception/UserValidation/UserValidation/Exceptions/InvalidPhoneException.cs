using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidation.Exceptions
{
    internal class InvalidPhoneException:ApplicationException
    {
        public InvalidPhoneException() {
            Console.WriteLine("Exception occured");
        }

        public InvalidPhoneException(string message) : base(message) { }
    }
}
