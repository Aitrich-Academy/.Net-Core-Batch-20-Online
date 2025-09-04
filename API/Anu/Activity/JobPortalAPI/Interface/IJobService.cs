using JobPortalAPI.DTO;
using JobPortalAPI.Models;

namespace JobPortalAPI.Interface
{
    public interface IJobService
    {
        Task<JobDto> AddJobAsync(JobDto jobDto);

        Task<IEnumerable<JobDto>> GetJobsAsync();

        Task<JobDto> GetJobByIdAsync(int id);

        Task<JobDto> UpdateJobAsync(int id, JobDto jobDto);

        Task<bool> DeleteJobAsync(int id);
    }
}
