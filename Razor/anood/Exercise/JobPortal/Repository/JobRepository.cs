using AutoMapper;
using Hangfire.MemoryStorage.Dto;
using JobPortal.Dto;
using JobPortal.Interface;
using JobPortal.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Repository
{
    public class JobRepository : IJobRepository 
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public JobRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<Jobs>> GetAllJobsAsync()
        {
            var jobs = await _context.Jobs.ToListAsync();
            return jobs;

        }
        public async Task AddJobsAsync(JobsDto jobsDto)
        {
            var job = _mapper.Map<Jobs>(jobsDto);
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
        }

         public async Task ApplyToJobAsync(int userId, int jobId)
         {
             bool exists = await _context.AppliedJobs
        .AnyAsync(a => a.UserId == userId && a.JobId == jobId);

             if (!exists)
             {
                 _context.AppliedJobs.Add(new Applied 
                 {
                     UserId = userId,
                     JobId = jobId,
                     AppliedDate = DateTime.UtcNow  // set timestamp here
                 });
                 await _context.SaveChangesAsync();
             }
         }


        public async Task<Jobs> GetJobByIdAsync(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            return _mapper.Map<Jobs>(job);
        }

        
    }
}
