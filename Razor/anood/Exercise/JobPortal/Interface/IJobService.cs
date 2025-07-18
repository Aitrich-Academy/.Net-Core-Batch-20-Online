using JobPortal.Dto;
using JobPortal.Model;
using JobPortal.Repository;

namespace JobPortal.Interface
{
    public interface  IJobService
    {
        public Task<List<Jobs>> GetAllJobsAsync();
        public Task AddJobsAsync(JobsDto jobsDto);
        public Task<Jobs> GetJobByIdAsync(int id);

        public Task ApplyToJobAsync(int userId, int jobId);

        
    }
}
