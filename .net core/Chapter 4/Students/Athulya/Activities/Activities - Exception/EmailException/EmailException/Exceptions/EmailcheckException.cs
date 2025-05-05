using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailException.Exceptions
{
    public class EmailcheckException:ApplicationException
    {
        public EmailcheckException()
        {
            Console.WriteLine("Exception");
        }
        public EmailcheckException(string message):base(message)
        {
            //Console.WriteLine(message);
        }
    }
}
