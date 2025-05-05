using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminJob.Enums;

namespace AdminJob.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }

        public User() { }
        public User(int id, string fname, string lname, string email,int phone, string password, Roles roles)
        {
            Id = id;
            FirstName = fname;
            LastName = lname;
            Email = email;
            Phone = phone;
            Password = password;
            Role = roles;
        }

    }
}
