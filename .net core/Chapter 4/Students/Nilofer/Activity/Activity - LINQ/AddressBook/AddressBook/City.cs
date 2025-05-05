using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class City : Address
    {
        public string CityId;
        public string CityName;
       

        public City() { }

        public City(string cityid, string cityname, int room,string building,string street,string phone,string email,string fname,string lname,DateTime dob,Address home,Address work) : base(room,building,street,phone,email,fname,lname,dob,home,work)
        {
            CityId = cityid;
            CityName = cityname;
          
        }

    }
}
