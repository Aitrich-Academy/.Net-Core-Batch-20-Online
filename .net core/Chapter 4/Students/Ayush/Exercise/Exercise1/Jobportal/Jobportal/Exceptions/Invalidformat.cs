using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobportal.Exceptions
{
    public class Invalidformat : Exception
    {
        public Invalidformat() { }

        public Invalidformat(string message) : base(message) { }
    }
}
