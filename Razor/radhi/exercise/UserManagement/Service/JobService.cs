using UserManagement.Dto;
using UserManagement.Interface;
using UserManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UserManagement.Service
{
    public class JobService : IJobService
    {
        private readonly IJobRepository jobrepository;

        public JobService(IJobRepository jobrepository)
        {
            this.jobrepository = jobrepository;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await jobrepository.GetAllJobsAsync();
        }

        public async Task<Job> GetJobByIdAsync(int id)
        {
            return await jobrepository.GetJobByIdAsync(id);
        }

        public async Task AddJobAsync(JobDto jobDto)
        {
            await jobrepository.AddJobAsync(jobDto);
        }
    }
}
