using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mailvalidation
{
    public class EmailException : ApplicationException
    {
        public EmailException() 
        {
            Console.WriteLine("Email not valid!!!!");
           
        }

        public EmailException(string message) : base(message)
        {
            
        }
    }
}
