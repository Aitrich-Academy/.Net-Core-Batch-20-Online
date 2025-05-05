using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jobportal.Models;

namespace Jobportal.Interfaces
{
    public interface IJobrepository
    {
        List<Job> GetAllJobs();
    }
}
