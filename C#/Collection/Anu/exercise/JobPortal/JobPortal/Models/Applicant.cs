using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Interfaces;

namespace JobPortal.Models
{
    public class Applicant : User, IApplicant
    {
        public List<Job> SavedJobs { get; set; } = new List<Job>();
        public List<Application> Applications { get; set; } = new List<Application>();
    }
}
