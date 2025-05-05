using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserValidation
{
    internal class User
    {
        public int Id;
        public string Name;
        public string Email;
        public string Phone;

        public User() { }

        public User(int id, string name, string email, string phone)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
                
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}   Name: {Name}  Email: {Email}  Phone: {Phone}");
        }

    }
}
