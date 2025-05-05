using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationActivity1Exception.VlidationException
{
    internal class PhoneException:ApplicationException
    {
      public  PhoneException()
        {
            Console.WriteLine("Invalid");
        }
        public  PhoneException(string message):base(message)
        {
            Console.WriteLine("only 10 digits");
        }
    }
}
