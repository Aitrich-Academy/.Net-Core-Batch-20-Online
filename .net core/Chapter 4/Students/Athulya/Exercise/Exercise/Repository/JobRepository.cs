using Exercise.Interface;
using Exercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Exercise.Enum.ExperienceLevel;

namespace Exercise.Repository
{
    public class JobRepository : IJobRepository
    {
        public JobRepository() { }

        List<Jobs> jobs = new List<Jobs>()
        {
            new Jobs {Title="Software Engineer ",ExperienceLevel = ExperienceLevels.Senior, Company = "Acme Inc.", Location = "New York, NY", SalaryRange = "$100,000 - $150,000",JobType="Full Time" },
            new Jobs { Title = "Product Manager", ExperienceLevel = ExperienceLevels.MidLevel, Company = "Globex Corp.", Location = "San Francisco, CA", SalaryRange = "$120,000 - $180,000", JobType="Part Time" },
           
        };
        public List<Jobs> GetJobs()
        { return jobs; }

      
    }
}
