using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4.Models
{
    internal class Job
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }

        public string Location { get; set; }
        public string Type { get; set; }
        public string Salaryrange { get; set; }

        public string Company { get; set; }


        public Job(string title,string description,string location,string type,string salaryrange,string company)
        {
            
            Title= title;
            Description= description;
            Location= location;
            Type= type;
                
            Salaryrange= salaryrange;
            Company= company;

        }

    }
}
