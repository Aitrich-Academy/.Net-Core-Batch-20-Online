using JobSeekerPortal.Interfaces;
using JobSeekerPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace JobSeekerPortal.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly AppDbContext _context;
        public JobRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Job?> GetByIdAsync(int id)
        {
            return await _context.Jobs.FindAsync(id);
        }

        public async Task<IEnumerable<Job>> GetAllAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

        public async Task AddAsync(Job job)
        {
            await _context.Jobs.AddAsync(job);
        }

        public void Update(Job job)
        {
            _context.Jobs.Update(job);
        }

        public void Delete(Job job)
        {
            _context.Jobs.Remove(job);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
