using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetails
{
    public class User
    {
        public User() { }
        public string Name { get; set; }
        public int ID { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        //public User(int iD, string name, string email, string phone) 
        //{
        //    ID = iD;
        //    Name = name;
        //    Email = email;
        //    Phone = phone;
        //}   
    }
}
