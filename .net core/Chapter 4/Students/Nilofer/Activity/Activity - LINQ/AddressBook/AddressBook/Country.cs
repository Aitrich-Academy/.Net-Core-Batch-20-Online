using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Country : City
    {
        public string CountryID { get; set; }
        public string CountryName { get; set; }

        public Country() { }

        public Country(string Countryid, string Cname,string cityId, string cityName,int room,string building,string street,string phone,string email,string fname,string lname,DateTime dob,Address home,Address work):base(cityId,cityName,room,building,street,phone,email,fname,lname,dob,home,work)
        {
            CountryID = Countryid;
            CountryName = Cname;
        }
        

        public void DisplayDetails()
        {

            Console.WriteLine($"First Name :{FirstName} ");
            Console.WriteLine($"Last Name : {LastName}");
            Console.WriteLine($"Date of Birth :  {DateOfBirth.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"----Home Address-------");
            Console.WriteLine($"Room No : {HomeAddress.RoomNumber}");
            Console.WriteLine($"Building : {HomeAddress.Building}");
            Console.WriteLine($"Street : {HomeAddress.Street}");
            Console.WriteLine($"Phone Number : {HomeAddress.Phone}");
            Console.WriteLine($"Email id : {HomeAddress.Email}");
            Console.WriteLine($"City id : {CityId}");
            Console.WriteLine($"City Name : {CityName}");
            Console.WriteLine($"Country Id : {CountryID}");
            Console.WriteLine($"Country Name : {CountryName}");
            Console.WriteLine();
            Console.WriteLine("--------Work Address---------");
            Console.WriteLine($"Room No : {HomeAddress.RoomNumber}");
            Console.WriteLine($"Building : {HomeAddress.Building}");
            Console.WriteLine($"Street : {HomeAddress.Street}");
            Console.WriteLine($"Phone Number : {HomeAddress.Phone}");
            Console.WriteLine($"Email id : {HomeAddress.Email}");
            Console.WriteLine($"City id : {CityId}");
            Console.WriteLine($"City Name : {CityName}");
            Console.WriteLine($"Country Id : {CountryID}");
            Console.WriteLine($"Country Name : {CountryName}");
            Console.WriteLine("------------------------------------------------\n");

        }

    }
}
