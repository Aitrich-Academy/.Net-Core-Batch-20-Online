using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    public class Address : Person
    {
        public int rollnumber;
        public string building;
        public string street;
        public string phone;
        public string email;

        public Address() { }

        public Address(string firstname, string lastname, int age, string homeaddress, string workaddress, int rollnumber, string building, string street, string phone, string email):
            base(firstname,lastname, age, homeaddress,workaddress)
        { 
            this.rollnumber = rollnumber;
            this.building = building;
            this.street = street;
            this.phone = phone;
            this.email = email;
            

        }
    }
}
