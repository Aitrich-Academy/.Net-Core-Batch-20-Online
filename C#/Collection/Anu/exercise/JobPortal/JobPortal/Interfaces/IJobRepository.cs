using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Models;

namespace JobPortal.Interfaces
{
    public interface IJobRepository
    {
        void AddJob(Job job);
        List<Job> GetAllJobs();
        List<Job> GetJobsByProvider(string providerUsername);
    }
}
