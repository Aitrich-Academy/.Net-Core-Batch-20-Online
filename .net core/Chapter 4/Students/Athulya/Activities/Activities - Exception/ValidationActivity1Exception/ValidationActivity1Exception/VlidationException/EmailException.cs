using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationActivity1Exception.VlidationException
{
    internal class EmailException:ApplicationException
    {
        public EmailException()
        {
            Console.WriteLine("Invalid ");
        }
        public EmailException(string message):base(message)
        {
            Console.WriteLine("Email is incorrect pattern");
        }
    }
}
