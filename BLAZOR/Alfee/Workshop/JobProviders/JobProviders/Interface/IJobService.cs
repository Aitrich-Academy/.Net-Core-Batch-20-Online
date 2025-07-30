using JobProviders.Dto;

namespace JobProviders.Interface
{
    public interface IJobService
    {
        Task<List<JobDto>> GetJobsByProviderIdAsync(int providerId);
        Task<bool> AddJobAsync(JobDto jobDto, int providerId);
        Task<bool> UpdateJobAsync(JobDto jobDto);
        Task<bool> DeleteJobAsync(int jobId);
        Task<JobDto> GetJobByIdAsync(int id);
    }
}
