using JobApi.Interface;
using JobApi.Models;
using Microsoft.EntityFrameworkCore;

namespace JobApi.Repository
{
    public class JobRepository:IJobRepository
    {

        private readonly ApplicationDbContext _context;

        public JobRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Job>> GetJobsAsync()
        {
            return await _context.Jobs.ToListAsync();
        }

        public async Task<Job> GetJobByIdAsync(int id)
        {
            return await _context.Jobs.FindAsync(id);
        }
        public async Task<Job> AddJobAsync(Job job, int userId)
        {
            job.UserId = userId; // Assign logged-in user's ID

            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();

            return job;
        }
        public async Task<Job> GetJobByIdAndUserAsync(int jobId, int userId)
        {
            return await _context.Jobs
                .FirstOrDefaultAsync(j => j.Id == jobId && j.UserId == userId);
        }

        public async Task<Job> UpdateJobAsync(Job job)
        {
            _context.Jobs.Update(job);
            await _context.SaveChangesAsync();
            return job;
        }

      

            public async Task<bool> DeleteJobAsync(int jobId, int userId)
            {
                var job = await _context.Jobs
                                        .FirstOrDefaultAsync(j => j.Id == jobId && j.UserId == userId);

                if (job == null)
                    return false;

                _context.Jobs.Remove(job);
                await _context.SaveChangesAsync();
                return true;
            }
        }


    }

