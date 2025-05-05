using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Person
    {
        public Person() { }
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress {  get; set; }

        public Person (string firstName, string lastName, int age, string home, string work)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeAddress = home;
            WorkAddress = work;
        }
     
    }
}
