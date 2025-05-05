using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercise.Enum.ExperienceLevel;

namespace Exercise.Model
{
    public class Jobs
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Company { get; set; }
        public ExperienceLevels ExperienceLevel { get; set; }
        public string Location { get; set; }
        public string SalaryRange { get; set; }
        public string JobType { get; set; }

        public Jobs() { }

        public Jobs( string title, string company, ExperienceLevels experienceLevel, string location, string salaryRange, string jobType)
        {
          
            Title = title;
            Company = company;
            ExperienceLevel = experienceLevel;
            Location = location;
            SalaryRange = salaryRange;
            JobType = jobType;
        }
    }
}
