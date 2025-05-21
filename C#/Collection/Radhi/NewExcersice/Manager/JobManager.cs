using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewExcersice.Interfaces;
using NewExcersice.Model;

namespace NewExcersice.Manager
{
    public class JobManager
    {
        private readonly IJobRepository _jobRepo;

        public JobManager(IJobRepository jobRepo)
        {
            _jobRepo = jobRepo;
        }

        public void PostJob(Job job)
        {
            _jobRepo.PostJob(job);
        }

        public List<Job> GetJobs()
        {
            return _jobRepo.GetAllJobs();
        }

        public Job GetJobById(int id)
        {
            return _jobRepo.GetJobById(id);
        }
    }
}
