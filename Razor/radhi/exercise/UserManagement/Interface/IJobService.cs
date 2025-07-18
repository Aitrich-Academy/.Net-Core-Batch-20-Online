using UserManagement.Dto;
using UserManagement.Models;

namespace UserManagement.Interface
{
    public interface IJobService
    {
        public Task<List<Job>> GetAllJobsAsync();

        public Task<Job> GetJobByIdAsync(int id);
        public Task AddJobAsync(JobDto jobDto);
    }
}
