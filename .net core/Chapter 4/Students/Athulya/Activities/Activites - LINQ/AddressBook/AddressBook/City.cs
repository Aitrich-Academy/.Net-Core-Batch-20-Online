using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class City:Address

    {
        public string CityId;
        public string CityName;
        public City() { }
        public City(string firstName,string lastName,int age,string homeAddress, string workAddress, int roomNumber, string building, string street, string phone, string email,string cityId,string cityName) : base(firstName, lastName, age, homeAddress, workAddress,roomNumber,building,street,phone,email)
        {
           this. CityId = cityId;
           this. CityName = cityName;
        }
    }
}
