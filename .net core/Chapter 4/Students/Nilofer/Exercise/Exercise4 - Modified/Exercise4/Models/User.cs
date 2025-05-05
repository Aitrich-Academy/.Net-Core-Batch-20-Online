using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise4.Enums;

namespace Exercise4.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }
        public long PhoneNo { get; set; }
        public string Password { get; set; }

        public Roles Role;

       





        public User() { }

        public User(int id, string fname,string lname,string email,long phoneNo,string password,Roles role)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
            Email = email;
            PhoneNo = phoneNo;
            Password = password;
            Role = role;

               
        }

       

    }
}
