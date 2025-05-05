using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyMember.Models;

namespace CompanyMember.Interfaces
{
    internal interface IJobProvider
    {
        void PostJob(Job job);
        List<Job> GetJobs();
    }
}
