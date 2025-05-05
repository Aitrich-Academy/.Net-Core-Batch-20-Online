using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcartscenario
{
   public class NotfoundExeception : Exception
    {
        public NotfoundExeception() { }

        public NotfoundExeception(string message) : base(message)
        {

        }
    }
}
