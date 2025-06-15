using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExcersice.Exceptions
{
  
        public class JobNotFoundException : System.Exception
        {
            public JobNotFoundException(string message) : base(message) { }
        }
    
}
