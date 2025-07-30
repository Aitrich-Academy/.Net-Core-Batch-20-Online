using JobProviders.Interface;
using JobProviders.Model;
using Microsoft.EntityFrameworkCore;

namespace JobProviders.Repository
{
    public class JobProviderRepository : IJobProviderRepository
    {
        private readonly JobProviderDbContext _context;

        public JobProviderRepository(JobProviderDbContext context)
        {
            _context = context;
        }

        public async Task<JobProvider> GetByEmailAsync(string email)
        {
            return await _context.JobProviders.FirstOrDefaultAsync(jp => jp.Email == email);
        }

        public async Task AddAsync(JobProvider jobProvider)
        {
            _context.JobProviders.Add(jobProvider);
            await _context.SaveChangesAsync();
        }


    }
}
