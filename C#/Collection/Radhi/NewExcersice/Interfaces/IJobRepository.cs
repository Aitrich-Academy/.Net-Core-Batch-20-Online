using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewExcersice.Model;

namespace NewExcersice.Interfaces
{
    public interface IJobRepository
    {
        void PostJob(Job job);
        List<Job> GetAllJobs();
        Job GetJobById(int jobId);
    }
}
