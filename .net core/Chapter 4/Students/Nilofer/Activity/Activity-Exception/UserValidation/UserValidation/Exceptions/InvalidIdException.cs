using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidation.Exceptions
{
    internal class InvalidIdException:ApplicationException
    {
        public InvalidIdException()
        {
            Console.WriteLine("Exception occured");
        }

        public InvalidIdException(string message) : base(message) { }
    }
}
