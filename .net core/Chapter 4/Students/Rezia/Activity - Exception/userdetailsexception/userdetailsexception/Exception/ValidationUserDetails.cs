using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userdetailsexception.Exception
{
    public class ValidationUserDetails : ApplicationException
    {
        public ValidationUserDetails() {
            Console.WriteLine("Exception");
        }
        public ValidationUserDetails(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
