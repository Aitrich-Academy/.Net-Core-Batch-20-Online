using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobProvider.Models;

namespace JobProvider.Interface
{
    internal interface IJobProvider
    {
      void  PostJob(Job job);

       List<Job> GetJobs();
    }
}
