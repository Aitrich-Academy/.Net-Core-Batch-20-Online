using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jobportal.Enums;

namespace Jobportal.Models
{
    public class User
    {
        public int Id;
        public string Firstname;
        public string Lastname;
        public string Email;
        public string Password;
        public long Phone;
        public Role roles;

        public User() { }

        public User(string firstname,string lastname, string email,string password,long phone,Role roles)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Email = email;
            this.Password = password;
            this.Phone = phone;
            this.roles = roles;

        }
    }
}
