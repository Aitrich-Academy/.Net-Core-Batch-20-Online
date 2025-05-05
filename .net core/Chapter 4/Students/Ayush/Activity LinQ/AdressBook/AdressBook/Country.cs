using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    public class Country : City
    {
        public string countryid;
        public string countryname;

        public Country() { }
        public Country(string firstname, string lastname, int age, string homeaddress, string workaddress, int rollnumber, string building, string street, string phone, string email, string cityid, string cityname, string countryid, string countryname) :
            base(firstname, lastname, age, homeaddress, workaddress, rollnumber, building, street, phone, email, cityid,cityname)
        {
            this.countryid = countryid;
            this.countryname = countryname;
        }

        public void displayperson()
        {
            Console.WriteLine("-----Details----");
            Console.WriteLine($"Fistname:{firstname} {lastname} ");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Country: {countryname}");
            Console.WriteLine($"City: {cityname}");
        }
    }
}
