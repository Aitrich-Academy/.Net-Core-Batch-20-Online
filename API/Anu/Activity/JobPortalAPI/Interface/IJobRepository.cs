using JobPortalAPI.Models;

namespace JobPortalAPI.Interface
{
    public interface IJobRepository
    {
        Task<Job> AddJobAsync(Job job);

        Task<IEnumerable<Job>> GetJobsAsync();

        Task<Job> GetJobByIdAsync(int id);

        Task<Job> UpdateJobAsync(Job job);

        Task<bool> DeleteJobAsync(int id);
    }


}
