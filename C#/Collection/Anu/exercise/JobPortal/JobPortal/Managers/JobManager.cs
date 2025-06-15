using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Interfaces;
using JobPortal.Models;

namespace JobPortal.Managers
{
    public class JobManager
    {
        private IJobRepository jobRepository;
        public JobManager(IJobRepository repository)
        {
            jobRepository = repository;
        }
        public void PostJob(Job job)
        {
            jobRepository.AddJob(job);
        }
        public List<Job> ListAllJobs()
        {
            return jobRepository.GetAllJobs();
        }
        public List<Job> ListJobsByProvider(string providerUsername)
        {
            return jobRepository.GetJobsByProvider(providerUsername);
        }
    }
}
