using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProvider.Models
{
    internal class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string Salary { get; set; }
        public string Company { get; set; }
        public Job() { }
        public Job(int id, string title, string description, string location, string type, string salary, string company)
        {
            Id = id;
            Title = title;
            Description = description;
            Location = location;
            Type = type;
            Salary = salary;
            Company = company;

        }
    
    }
}
