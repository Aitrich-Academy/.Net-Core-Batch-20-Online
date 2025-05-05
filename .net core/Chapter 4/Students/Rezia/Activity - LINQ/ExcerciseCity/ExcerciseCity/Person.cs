using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseCity
{
    internal class Person 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public Address HomeAddress { get; set; }

        public Address WorkAddress { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, DateTime dateofBirth, Address homeAddress, Address workAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            DateofBirth = dateofBirth;
            HomeAddress = homeAddress;
            WorkAddress = workAddress;
        }

        
    }
}
