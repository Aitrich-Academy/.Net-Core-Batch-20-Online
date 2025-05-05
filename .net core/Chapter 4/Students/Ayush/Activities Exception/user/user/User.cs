using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user
{
    public class User
    {
        public string id;
        public string name;
        public string email;
        public string phone;

        public User() { }

        public void newexe()
        {
            throw new UserException();
        }
        public User(string id,string name,string email,string phone)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phone = phone;

        }
    }

    public class UserException : ApplicationException
    {
        
        public UserException() 
        {
            Console.WriteLine("An Error occured!!");
        }

        public UserException(string message) : base(message){ }

        
    }
}
