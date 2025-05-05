using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Exceptions
{
   public class InvalidFormat : Exception
    {
        public InvalidFormat() { }
        public InvalidFormat(string message) : base(message)
        {
        }
    }
}
