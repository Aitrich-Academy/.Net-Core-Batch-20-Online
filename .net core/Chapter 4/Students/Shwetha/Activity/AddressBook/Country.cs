using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Country : City
    {
        public Country() { }
        public int Country_Id {  get; set; }
        public string Country_Name {  get; set; }

        public Country(int country_id, string contry_name, int id, string name, int room, string build, string street, string city, string phone, string email, string firstName, string lastName, int age, string home, string work) : base (id,  name, room,  build, street,  city,  phone,  email, firstName,  lastName,  age,  home,  work)
        {
            Country_Id = id;
            Country_Name = name;
        }
    }
}
