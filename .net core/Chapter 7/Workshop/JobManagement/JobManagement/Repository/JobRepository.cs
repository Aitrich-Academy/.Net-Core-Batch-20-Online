using AutoMapper;
using JobManagement.Dto;
using JobManagement.Interface;
using JobManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace JobManagement.Repository
{
    public class JobRepository:IJobRepository
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

        public async Task<Jobs> GetJobByIdAsync(int id)
        {
            var job = await _context.Jobs.FindAsync(id);
            return _mapper.Map<Jobs>(job);
        }

        public async Task AddJobAsync(JobDto jobDto)
        {
            var job = _mapper.Map<Jobs>(jobDto);
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateJobAsync(int id, Jobs jobDto)
        {
            var existingJob = await _context.Jobs.FindAsync(id);
            if (existingJob == null) return; // Ensure job exists

            _context.Entry(existingJob).State = EntityState.Detached; // Detach old instance

            var updatedJob = _mapper.Map<Jobs>(jobDto);
            updatedJob.Id = id; // Ensure the ID remains the same

            _context.Jobs.Attach(updatedJob); // Attach the new instance
            _context.Entry(updatedJob).State = EntityState.Modified; // Mark as modified

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
