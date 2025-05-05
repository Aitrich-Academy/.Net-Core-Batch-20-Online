using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidation.Exceptions
{
    internal class InvalidNameException:ApplicationException
    {
        public InvalidNameException()
        {
            Console.WriteLine("Exception occured");
        }

        public InvalidNameException(string message) : base(message) { }
    }
}
