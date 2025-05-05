using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyMember.Enums;

namespace CompanyMember.Models
{
    internal class Job
    {
        //private string description;
        //private string type;
        //private string salary;

        public int Id { get; set; }
        public string Title { get; set; }
        public ExperienceLevels ExperienceLevel { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string SalaryRange { get; set; }
        public string JobType { get; set; }

        public Job(string title, ExperienceLevels exp, string location, string type, string salary, string company)
        {
            Title = title;
            ExperienceLevel = exp;
            Location = location;
            JobType = type;
            SalaryRange = salary;
            Company = company;
        }

    }
}
