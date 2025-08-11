using Microsoft.EntityFrameworkCore;
using JobPortalMVC.Interface;
using JobPortalMVC.Models;
using JobPortalMVC.Dto;

namespace JobPortalMVC.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly JobAppDbContext _context;

        public JobRepository(JobAppDbContext context)
        {
            _context = context;
        }

        public async Task<Job> AddJob(Job job)
        {
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
            return job;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            var jobs = await _context.Jobs.ToListAsync();
            return jobs;

        }

        public async Task<Job> GetJobByIdAsync(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            return job;
        }

        public async Task UpdateAndSaveAsync(Job job)
        {
            _context.Jobs.Update(job);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteJobAsync(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            if (job != null)
            {
                _context.Jobs.Remove(job);
                await _context.SaveChangesAsync();
            }
        }


    }
}
