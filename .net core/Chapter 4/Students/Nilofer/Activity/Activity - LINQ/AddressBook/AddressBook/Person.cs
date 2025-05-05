using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Person 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address HomeAddress { get; set; }
        public Address WorkAddress { get; set; }

        public Person() { }

        public Person(string fname,string lname, DateTime dateOfBirth,Address home, Address work)
        {
            FirstName = fname;
            LastName = lname;
            DateOfBirth = dateOfBirth;
            HomeAddress = home;
            WorkAddress = work;
        }


       
    }
}
