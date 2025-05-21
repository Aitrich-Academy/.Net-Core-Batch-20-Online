using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewExcersice.Interfaces;
using NewExcersice.Model;

namespace NewExcersice.Repository
{
    public class JobRepository:IJobRepository
    {
        private readonly List<Job> _jobs = new();

        public void PostJob(Job job)
        {
            job.JobId = _jobs.Count + 1;
            _jobs.Add(job);
        }

        public List<Job> GetAllJobs() => _jobs;

        public Job GetJobById(int jobId) => _jobs.Find(j => j.JobId == jobId);
    }
}
