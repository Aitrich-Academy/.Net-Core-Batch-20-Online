using JobPortalMVC.Dto;
using JobPortalMVC.Models;

namespace JobPortalMVC.Interface
{
    public interface IJobRepository
    {
        Task<Job> AddJob(Job job);
        public Task<List<Job>> GetAllJobsAsync();

        public Task<Job> GetJobByIdAsync(int id);

        Task UpdateAndSaveAsync(Job job);

        public Task DeleteJobAsync(int id);

    }

}