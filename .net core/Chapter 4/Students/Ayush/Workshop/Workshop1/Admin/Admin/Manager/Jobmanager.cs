using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Interfaces;
using Admin.Models;

namespace Admin.Manager
{
    public class Jobmanager : IJobprovider
    {
        public Jobmanager() { }

        private List<Job> jobs=new List<Job>();

        public void Postjob(Job job)
        {
            job.Id = jobs.Count;
            jobs.Add(job);
        }

        public List<Job> GetJobs() {
            return jobs; 
        }
    }
}
