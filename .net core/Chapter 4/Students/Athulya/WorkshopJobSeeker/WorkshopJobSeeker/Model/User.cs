using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopJobSeeker.Enums;

namespace WorkshopJobSeeker.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long Phone { get; set; }
        public Roles Role { get;set; }  
        public User() { }
        public User(int id,string firstname,string lastname, string email, long phone, string password, Roles roles)
        {
           this. Id = id;
            this. FirstName = firstname;
            this. LastName = lastname;
            this. Email = email;
            this. Password = password;
            this.Phone = phone;
            this.Role = roles;

        }
    }
}
