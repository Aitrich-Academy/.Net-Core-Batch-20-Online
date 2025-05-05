using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopJobSeeker.Model;

namespace WorkshopJobSeeker.Interfaces
{
    public interface IJobRepository
    {
        List<Job> GetAllJobs();
    }
}
