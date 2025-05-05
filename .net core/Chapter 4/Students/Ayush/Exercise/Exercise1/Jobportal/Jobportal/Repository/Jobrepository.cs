using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jobportal.Enums;
using Jobportal.Interfaces;
using Jobportal.Models;
using static Jobportal.Enums.Experiencelevels;

namespace Jobportal.Repository
{
    public class Jobrepository : IJobrepository
    {

        public Jobrepository() { }

        List<Job> jobs = new List<Job>()
        {
            new Job{Id=1,Title="SoftwareEngineer",Experiencelevel=ExperienceLevel.Senior,Company="Acme Inc",Location="New York",Salary="$10000-$15000",Jobtype="Full Time"},
            new Job{Id=2,Title="ProductManager",Experiencelevel=ExperienceLevel.Midlevel,Company="Globex Corp",Location="Sanfrancisco",Salary="$12000-$18000",Jobtype="Part Time"}
        };

        public List<Job>GetAllJobs()
        {
            return jobs;
        }
    }
}
