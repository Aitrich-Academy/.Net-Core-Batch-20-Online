using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Interfaces;

namespace JobPortal.Models
{
    public class JobProvider : User, IJobProvider
    {
        public List<Job> PostedJobs { get; set; } = new List<Job>();
    }
}
