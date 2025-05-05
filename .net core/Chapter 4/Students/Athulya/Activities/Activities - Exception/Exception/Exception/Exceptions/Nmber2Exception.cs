using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleException.Exceptions
{
    public class Nmber2Exception:ApplicationException
    {
        public Nmber2Exception()
        {
            Console.WriteLine("Exception");
        }
        public Nmber2Exception(string message):base(message)
        {
            {
                Console.WriteLine(message);
            }

        }
    }
}
