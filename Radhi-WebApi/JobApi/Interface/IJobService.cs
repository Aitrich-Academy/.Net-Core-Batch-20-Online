using JobPortalAPI.DTOs;

namespace JobApi.Interface
{
    public interface IJobService
    {
        Task<IEnumerable<JobDTO>> GetJobsAsync();
        Task<JobDTO> GetJobByIdAsync(int id);
        Task<JobDTO> AddJobAsync(JobDTO jobDto,int userId);
        Task<JobDTO> UpdateJobAsync(int id, JobDTO jobDto, int userId);
       
        Task<bool> DeleteJobAsync(int id, int value);
    }
}
