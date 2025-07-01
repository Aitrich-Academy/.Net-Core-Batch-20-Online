using JOBMANAGEMENT.Dto;
using JOBMANAGEMENT.Models;

namespace JOBMANAGEMENT.Interface
{
    public interface IJobRepository
    {
        public Task<List<Job>> GetAllJobsAsync();

        public Task<Job> GetJobByIdAsync(int id);
        public Task AddJobAsync(JobDto jobDto);


        public Task UpdateJobAsync(int id, Job jobDto);

        public Task DeleteJobAsync(int id);
    }
}
