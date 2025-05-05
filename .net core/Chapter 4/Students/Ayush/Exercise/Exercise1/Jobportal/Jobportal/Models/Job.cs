using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jobportal.Enums;
using static Jobportal.Enums.Experiencelevels;

namespace Jobportal.Models
{
    public class Job
    {
        public int Id;
        public string Title;
        public ExperienceLevel Experiencelevel;
        public string Company;
        public string Location;
        public string Salary;
        public string Jobtype;


        public Job() { }

        


    }
}
