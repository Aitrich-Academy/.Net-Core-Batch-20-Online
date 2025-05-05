using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Address : Person
    {
       
        public int RoomNumber { get; set; }
        public string Building { get; set; }
        public string Street { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Address() { }

        public Address(int roomNo, string building, string street,string phone, string email,string fname,string lname,DateTime dob,Address home,Address work) :base(fname,lname,dob,home,work)
        {
            RoomNumber = roomNo;
            Building = building;
                
            Street = street;
            
            Phone = phone;
            Email = email;
        }

        public Address(int roomNumber, string building, string street, string phone, string email)
        {
            RoomNumber = roomNumber;
            Building = building;
            Street = street;
            Phone = phone;
            Email = email;
        }
    }
}
