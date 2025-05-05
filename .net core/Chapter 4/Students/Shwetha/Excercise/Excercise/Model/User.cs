using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise.Enums;

namespace Excercise.Model
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long Phone { get; set; }
        public Roles roles { get; set; }
        public User() { }

        public User(string name, string email, string password, long phone,Roles role)
        {
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
            roles = role;
        }

    }
}
