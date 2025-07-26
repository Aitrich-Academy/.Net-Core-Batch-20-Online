using WorkshopJobProviderApp.Model;
using Microsoft.EntityFrameworkCore;
using WorkshopJobProviderApp.Interface;

namespace WorkshopJobProviderApp.Repository
{
    public class JobProviderRepository:IJobProviderRepository
    {
        private readonly JobproviderAppDbContext _context;

        public JobProviderRepository(JobproviderAppDbContext context)
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

