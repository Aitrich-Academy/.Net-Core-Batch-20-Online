using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminJob.Models;

namespace AdminJob.Interface
{
    internal interface IJobProvider
    {
        void PostJob(Job job);

        List<Job> GetJobs();
    }
}
