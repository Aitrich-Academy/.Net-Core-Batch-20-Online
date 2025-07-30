using JobProviders.Model;

namespace JobProviders.Interface
{
    public interface IJobProviderRepository
    {
        Task<JobProvider> GetByEmailAsync(string email);
        Task AddAsync(JobProvider jobProvider);
    }
}
