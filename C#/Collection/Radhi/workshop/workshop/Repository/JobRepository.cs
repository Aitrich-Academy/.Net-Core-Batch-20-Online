using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop.Interfaces;
using workshop.Model;

namespace workshop.Repository
{
   
        public class JobRepository : IJobRepository
        {
            public JobRepository()
            {

            }
            List<Job> jobs = new List<Job>();

            public List<Job> GetAllJobs()
            {
                return jobs;
            }
        }
    
}
