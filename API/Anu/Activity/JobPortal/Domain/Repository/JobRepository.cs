using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Domain.Interface;

namespace Domain.Repository
{
    public class JobRepository :IJobRepository 
    {
        public readonly ApplicationDbContext _contex;
        public JobRepository(ApplicationDbContext contex)
        {
            _contex = contex;
        }

        public async Task<IEnumerable<Job>> GetAllJobsAsync()
        {
            return await _contex.Jobs.ToListAsync();
        }
        public async Task<Job> GetJobByIdAsync(int id)
        {
            return await _contex.Jobs.FindAsync(id);
        }

        public async Task<Job> AddJobAsync(Job job)
        {
            _contex.Jobs.Add(job);
            await _contex.SaveChangesAsync();
            return job;
        }

        public async Task<Job> UpdateJobAsync(Job job)
        {
            _contex.Jobs.Update(job);
            await _contex.SaveChangesAsync();
            return job;
        }

        public async Task<bool> DeleteJobAsync(int id)
        {
            var job = await _contex.Jobs.FindAsync(id);
            if (job == null) return false;

            _contex.Jobs.Remove(job);
            await _contex.SaveChangesAsync();
            return true;
        }
    }
}

