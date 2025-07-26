using WorkshopJobProviderApp.Model;

namespace WorkshopJobProviderApp.Interface
{
    public interface IJobProviderRepository
    {
        Task<JobProvider> GetByEmailAsync(string email);
        Task AddAsync(JobProvider jobProvider);
    }
}
