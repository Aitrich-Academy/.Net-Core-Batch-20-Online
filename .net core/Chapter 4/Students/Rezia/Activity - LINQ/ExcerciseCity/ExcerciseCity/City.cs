using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcerciseCity
{
    internal class City : Address
    {
        public int CityId { get; set; } 
        public string CityName { get; set; }
     
       public City() { }
        public City(int CityId, string CityName, string roomNumber, string building, string street, long phone, string email, string firstName, string lastName, DateTime dateofBirth, Address homeAddress, Address workAddress) : base( roomNumber, building, street, phone, email, firstName, lastName, dateofBirth, homeAddress, workAddress)
        {
            this.CityId = CityId;
            this.CityName = CityName;
        }
    }
}
