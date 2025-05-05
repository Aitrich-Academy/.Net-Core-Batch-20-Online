using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetails
{
    public class EmailException : ApplicationException
    {
        public EmailException() 
        { 
            Console.WriteLine("Invalid Email ID");
        }
        public EmailException(string message) : base(message)
        {
            Console.WriteLine("Email id is incorrect format(abc[12]@mail.com)");
        }
    }
}
