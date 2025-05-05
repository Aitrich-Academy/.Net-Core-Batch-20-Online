using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Exceptions
{
   public class Useralreadyexist : Exception
    {
        public Useralreadyexist() { }
        public Useralreadyexist(string email)
            : base(String.Format($"user already exist with this email: {email} !!!"))
        { 
        }
    }
}
