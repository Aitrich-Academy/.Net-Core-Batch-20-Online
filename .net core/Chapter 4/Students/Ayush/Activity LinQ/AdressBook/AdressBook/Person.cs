using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    public class Person
    {
        public string firstname;
        public string lastname;
        public int age;
        public string homeaddress;
        public string workaddress;


        public Person() { }


        public Person(string firstname, string lastname,int age, string homeaddress, string workaddress)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.homeaddress = homeaddress;
            this.workaddress = workaddress;
        }
    }
}
