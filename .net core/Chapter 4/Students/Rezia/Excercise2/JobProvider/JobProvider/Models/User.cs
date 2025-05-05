using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobProvider.Enums;

namespace JobProvider.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long PhoneNumber {  get; set; }
        public Roles Role {  get; set; }

        public User() { }
        public User(int id, string fname, string lastName, string email, string password, long phonenum,Roles roles)
        {
            Id = id;
            FirstName = fname;
            LastName = lastName;
            Email = email;
            Password = password;
            PhoneNumber = phonenum;
            Role = roles;

        }
       
    }
}
