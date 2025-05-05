using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise.Model
{
    public class Interview
    {
        public Interview() { }
        public int Id { get; set; }
        public string Post_Name { get; set; }
        public string Post_Description { get; set; }

        public string Date {  get; set; }
        public string Location { get; set; }

        public Interview(int id, string post_Name, string post_Description, string date, string location)
        {
            Id = id;
            Post_Name = post_Name;
            Post_Description = post_Description;
            Date = date;
            Location = location;
        }
    }
}
