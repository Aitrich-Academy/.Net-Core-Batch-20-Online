using JobApi.Model;
using JobApi.Models;

namespace JobApi.Interface
{
    public interface IJobRepository
    {
        Task<IEnumerable<Job>> GetJobsAsync();
        Task<Job> GetJobByIdAsync(int id);
        Task<Job> AddJobAsync(Job job,int userId);
        Task<Job> UpdateJobAsync(Job job);
        Task<bool> DeleteJobAsync(int id,int userId);
        Task<Job> GetJobByIdAndUserAsync(int jobId, int userId);

    }
}
