using Exercise.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Model
{
    public class User
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long Phone { get; set; }
        public Roles roles { get; set; }
        

        public User() { }
        public User( string firstname, string lastname, string email, long phone, string password, Roles role)
        {
            
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Email = email;
            this.Password = password;
            this.Phone = phone;
            roles = role;

        }

        internal void Display()
        {
            throw new NotImplementedException();
        }
    }
}
