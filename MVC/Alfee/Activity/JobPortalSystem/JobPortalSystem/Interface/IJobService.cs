using JobPortalSystem.Dto;

namespace JobPortalSystem.Interface
{
    public interface IJobService
    {
        Task<IEnumerable<JobDto>> GetAllJobs();
        Task<JobDto> GetJobById(int id);
        Task<JobDto> AddJob(JobDto jobDto);
        Task<JobDto> UpdateJob(JobDto jobDto);
        Task<bool> DeleteJob(int id);
    }
}
