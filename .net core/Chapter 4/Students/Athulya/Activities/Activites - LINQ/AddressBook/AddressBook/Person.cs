using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
   public class Person
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
       
        public int Age {  get; set; }
        public string HomeAddress {  get; set; }
        public string WorkAddress { get; set; }
       
        public Person() { }
        public Person(string firstName, string lastName,int age, string homeAddress, string workAddress)
        {
           this. FirstName = firstName;
           this. LastName = lastName;
         this.Age= age;
           this. HomeAddress = homeAddress;
           this. WorkAddress = workAddress;
            //age= age = DateTime.Now.Year - dateOfBirth.Year;
            //if(DateTime.Now.DayOfYear<dateOfBirth.DayOfYear)
            //{
            //    age = age - 1;
            //}

        }

        //public void DisplayDetails()
        //{
        //    Console.WriteLine("Name:{0}  {1}", FirstName, LastName);
        //    Console.WriteLine("Date of Birth:{0}", DateOfBirth);
        //    Console.WriteLine("Home Address:");
            

        //}

    }
}
