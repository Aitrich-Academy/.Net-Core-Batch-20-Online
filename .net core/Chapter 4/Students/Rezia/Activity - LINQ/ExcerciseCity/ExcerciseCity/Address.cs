using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseCity
{
    internal class Address : Person
    {
        public string RoomNumber { get; set; }
        public string Building { get; set; }

        public string Street { get; set; }
       
        public long Phone {  get; set; }
        public string Email { get; set; }

        public Address() { }
        public Address(string roomNumber, string building, string street, long phone, string email,string firstName, string lastName, DateTime dateofBirth, Address homeAddress, Address workAddress)  : base (firstName,lastName, dateofBirth, homeAddress,workAddress)
        {
            RoomNumber = roomNumber;
            Building = building;
            Street = street;
           
            Phone = phone;
            Email = email;
        }
        public Address(string roomNumber, string building, string street, long phone, string email)
        {
            RoomNumber = roomNumber;
            Building = building;
            Street = street;
            Phone = phone;
            Email = email;
        }
    }
}
