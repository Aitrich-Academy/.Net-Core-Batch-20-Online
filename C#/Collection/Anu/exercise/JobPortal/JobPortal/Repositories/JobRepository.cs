using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Interfaces;
using JobPortal.Models;

namespace JobPortal.Repositories
{
    public class JobRepository : IJobRepository
    {
        private List<Job> jobs = new List<Job>();
        private int nextId = 1;

        public void AddJob(Job job)
        {
            job.Id = nextId++;
            jobs.Add(job);
        }

        public List<Job> GetAllJobs()
        {
            return jobs;
        }

        public List<Job> GetJobsByProvider(string providerUsername)
        {
            return jobs.Where(j => j.ProviderUsername == providerUsername).ToList();
        }
    }
}
