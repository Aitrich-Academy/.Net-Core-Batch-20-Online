using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class EmailValidation:ApplicationException
    {
        public EmailValidation()
        {
            Console.WriteLine("Exception occured");
        }
        public EmailValidation(string message): base(message) {
        

        }
    }
}
