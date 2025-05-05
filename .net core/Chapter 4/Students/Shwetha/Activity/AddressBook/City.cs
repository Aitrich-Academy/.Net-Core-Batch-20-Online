using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class City : Address
    {
        public City() { }
        public int ID { get; set; }
        public string City_Name { get; set; }

        public City(int id, string name, int room, string build, string street, string city, string phone, string email, string firstName, string lastName, int age, string home, string work) : base (room,  build, street,  city,  phone,  email,  firstName,  lastName,  age,  home,  work)
        {
            ID = id;
            City_Name = name;
        }
    }
}
