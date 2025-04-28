using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortalApplication.Models;

namespace JobPortalApplication.Interfaces
{
    public interface IJobProvider
    {
        void PostJob(Job job);
        Job[] GetJobs();
    }
}
