using WorkshopJobProviderApp.Dto;

namespace WorkshopJobProviderApp.Interface
{
    public interface IJobservice
    {
        Task<List<JobDto>> GetJobsByProviderIdAsync(int providerId);
        Task<bool> AddJobAsync(JobDto jobDto, int providerId);
        Task<bool> UpdateJobAsync(JobDto jobDto);
        Task<bool> DeleteJobAsync(int jobId);
    }
}
