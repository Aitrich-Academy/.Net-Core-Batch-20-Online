using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseCity
{
    internal class Country : City
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public Country() { }
        public Country(int CountryID, string CountryName, int CityId, string CityName, string roomNumber, string building, string street, long phone, string email, string firstName, string lastName, DateTime dateofBirth, Address homeAddress, Address workAddress) : base( CityId,CityName, roomNumber, building, street, phone, email, firstName, lastName, dateofBirth, homeAddress, workAddress)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;

        }

        public void dispalydetails()
        {
            Console.WriteLine("Welcome to Information System Application");
            Console.WriteLine($"Full Name : {FirstName} {LastName}");
            Console.WriteLine($"Date of Birth  : {DateofBirth.ToString("dd/mm/yyyy")}");
            Console.WriteLine($"----------------Home Address------------------ - ");
            Console.WriteLine($"Room No : {RoomNumber}");
            Console.WriteLine($"Building Name : {Building}");
            Console.WriteLine($"Street Name : {Street}");
            Console.WriteLine($"Phone Number : {Phone}");
            Console.WriteLine($"Email : {Email}");
            Console.WriteLine($"City Id : {CityId}");
            Console.WriteLine($"City Name : {CityName}");
            Console.WriteLine($"Country Id : {CountryID}");
            Console.WriteLine($"Country Name : {CountryName}");
            Console.WriteLine("=====================Work Address===================");
            Console.WriteLine($"Office Room No : {RoomNumber}");
            Console.WriteLine($"Office Building Name : {Building}");
            Console.WriteLine($"Office Street Name : {Street}");
            Console.WriteLine($"Office Phone Number : {Phone}");
            Console.WriteLine($"Office Email : {Email}");
            Console.WriteLine($"City Id : {CityId}");
            Console.WriteLine($"City Name : {CityName}");
            Console.WriteLine($"Country Id : {CountryID}");
            Console.WriteLine($"Country Name : {CountryName}");
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
