using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetails
{
    public class PhoneException : ApplicationException
    {
        public PhoneException() 
        {
            Console.WriteLine("Invalid phone number"); 
        }
        public PhoneException(string message) : base(message)
        {
            Console.WriteLine("phone number must have 10 digits");
        }
    }
}
