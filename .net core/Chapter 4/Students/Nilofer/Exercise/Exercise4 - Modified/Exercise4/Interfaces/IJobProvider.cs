using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise4.Models;

namespace Exercise4.Interfaces
{
    internal interface IJobProvider
    {
        void PostJob(Job job);

        List<Job> GetJobs();

    }
}
