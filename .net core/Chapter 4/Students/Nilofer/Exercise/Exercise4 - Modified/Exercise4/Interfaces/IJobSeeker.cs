using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise4.Models;

namespace Exercise4.Interfaces
{
    internal interface IJobSeeker
    {
        void ApplyJob();

        List<Job> GetJobs();

        void SaveJob(Job job);
    }
}
