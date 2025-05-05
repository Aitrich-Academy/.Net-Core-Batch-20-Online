using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Country:City
    {
        public string CountryId { get; set; }
        public string CountryName { get; set; }
        public Country() { }
        public Country (string firstName, string lastName, int age, string homeaddress, string workaddress, int roomnumber, string building, string street, string phone, string email, string cityId, string cityName, string countryId, string countryName) :
            base(firstName, lastName, age, homeaddress, workaddress, roomnumber, building, street, phone, email, cityId, cityName)
        {
            this.CountryId = countryId;
            this.CountryName = countryName;
        }
        public void display()
        {
            Console.WriteLine("-----Details----");
            Console.WriteLine("Fistname:{0} {1} ",FirstName,LastName);
            Console.WriteLine("Age: {0}",Age);
            Console.WriteLine("Country: {0}",CountryName);
            Console.WriteLine("City: {0}",CityName);
        }
    }
}
