using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Interface
{
    public interface IJobRepository
    {
        Task<Job> AddJobAsync(Job job);
        Task<Job> GetJobByIdAsync(int id);
        Task<IEnumerable<Job>> GetAllJobsAsync();
        Task<Job> UpdateJobAsync(Job job);
        Task<Job> DeleteJobAsync(int id);
    }
}
