using JobSeekerPortal.Dtos;

namespace JobSeekerPortal.Interfaces
{
    public interface IJobService
    {
        Task<JobDto?> GetByIdAsync(int id);
        Task<IEnumerable<JobDto>> GetAllAsync();
        Task AddJobAsync(JobDto jobDto);
        Task UpdateJobAsync(JobDto jobDto);
    }
}
