using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Enums;

namespace Admin.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public long Phone {  get; set; }
        public Roles Roles { get; set; }

        public User() { }

        public User(int id, string firstname, string lastname, string email, string password, long phone, Roles roles)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            Phone = phone;
            Roles = roles;
        }
    }
}
