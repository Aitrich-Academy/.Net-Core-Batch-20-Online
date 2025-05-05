using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationActivity1Exception.VlidationException
{
    internal class IDException:ApplicationException
    {
        public IDException()
        {
            Console.WriteLine("Invalid");
        }
        public IDException(string message)
        {
            Console.WriteLine("Only Digits");
        }

    }
}
