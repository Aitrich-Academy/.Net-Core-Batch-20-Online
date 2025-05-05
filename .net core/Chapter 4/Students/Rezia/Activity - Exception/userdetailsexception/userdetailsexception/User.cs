using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userdetailsexception
{
    internal class User
    {
        public int id;
        public string name;
        public string phone;
        public string email;

        public User() { }

        public User(int id, string name,  string phone, string email) {
            this.id = id;
            this.name = name;          
            this.phone = phone;
            this.email = email;

        }
        public override string ToString() {
            return $"ID : {id}, Name : {name},  Phone : {phone}, Email : {email}";
        }
    }
}
