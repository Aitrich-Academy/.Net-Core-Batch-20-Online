using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Address : Person
    {
        public Address() { }

        public int RoomNo { get; set; }
        public string Building { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Address(int room, string build, string street, string city, string phone, string email, string firstName, string lastName, int age, string home, string work) : base(firstName, lastName, age, home, work)
        {
            RoomNo = room;
            Building = build;
            Street = street;
            City = city;
            Phone = phone;
            Email = email;
        }

    }
}
