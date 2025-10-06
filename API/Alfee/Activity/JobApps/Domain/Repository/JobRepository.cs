using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.Repository
{
    public class JobRepository:IJobRepository
    {
        private readonly ApplicationDbContext _context;
        public JobRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Job>> GetAllJobsAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

        public async Task<Job> GetJobByIdAsync(int id)
        {
            return await _context.Jobs.FindAsync();
        }

        public async Task<Job> AddJobAsync(Job job)
        {
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
            return job;
        }

        public async Task<Job> UpdateJobAsync(Job job)
        {
            _context.Jobs.Update(job);
            await _context.SaveChangesAsync();
            return job;
        }

        public async Task<Job> DeleteJobAsync(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            if(job != null)
            {
                _context.Jobs.Remove(job);
                await _context.SaveChangesAsync();
            }
            return job;
        }
    }
}
