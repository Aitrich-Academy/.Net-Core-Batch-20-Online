using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyMember.Interfaces;
using CompanyMember.Model;

namespace CompanyMember.Repository
{
    public class JobRepository : IJobRepository
    {
        public JobRepository()
        {

        }
        List<Job> jobs = new List<Job>();

        public List<Job> GetAllJobs()
        {
            return jobs;
        }
    }
}
