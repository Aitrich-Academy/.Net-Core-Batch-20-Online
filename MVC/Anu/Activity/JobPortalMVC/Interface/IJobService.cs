using JobPortalMVC.Dto;
using JobPortalMVC.Models;

namespace JobPortalMVC.Interface
{
    public interface IJobService
    {
        Task<JobDto> AddJob(JobDto jobDto);

        public Task<List<Job>> GetAllJobsAsync();

        public Task<Job> GetJobByIdAsync(int id);

        Task UpdateJobAsync(int id, JobDto dto);

        public Task DeleteJobAsync(int id);
    }
}
 