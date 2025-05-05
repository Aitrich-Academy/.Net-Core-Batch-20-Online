using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    public class City : Address
    {
        public string cityid;
        public string cityname;

        public City() { }

        public City(string firstname, string lastname, int age, string homeaddress, string workaddress, int rollnumber, string building, string street, string phone, string email, string cityid, string cityname):
            base(firstname, lastname, age, homeaddress, workaddress, rollnumber, building,street,phone,email)
        {
            this.cityid = cityid;
            this.cityname = cityname;
        }
    }
}
