using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailException
{
  
    
        public class E_Exception : ApplicationException
        {
            public E_Exception()  { Console.WriteLine("Invalid Email ID"); }
            public E_Exception(string message) : base(message) 
            {
                Console.WriteLine("Email id is incorrect format");
            }
        }

    
}
