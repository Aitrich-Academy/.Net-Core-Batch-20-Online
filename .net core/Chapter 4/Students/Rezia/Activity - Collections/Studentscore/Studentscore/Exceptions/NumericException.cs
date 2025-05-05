using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentscore.Exceptions
{
    internal class NumericException :ApplicationException
    {
        public NumericException() { }
        public NumericException(string message)
        { 
        throw new Exception(message);
        }
    }
}
