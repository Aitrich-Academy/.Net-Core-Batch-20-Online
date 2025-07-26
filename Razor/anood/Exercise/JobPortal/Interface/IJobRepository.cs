using Hangfire.MemoryStorage.Dto;
using JobPortal.Dto;
using JobPortal.Model;

namespace JobPortal.Interface
{
    public interface IJobRepository
    {
        public Task<List<Jobs>> GetAllJobsAsync();
        public Task AddJobsAsync(JobsDto jobsDto);

        public Task<Jobs> GetJobByIdAsync(int id);

         public Task ApplyToJobAsync(int userId, int jobId);

        

        

    }
}
