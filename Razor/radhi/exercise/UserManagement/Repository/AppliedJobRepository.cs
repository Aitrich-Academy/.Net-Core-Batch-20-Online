using System;
using UserManagement.Models;
using UserManagement.Interface;
using Microsoft.EntityFrameworkCore;

namespace UserManagement.Repository
{
    public class AppliedJobRepository:IAppliedRepository
    {
        private readonly ApplicationDbContext _context;

        public AppliedJobRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task ApplyForJobAsync(int userId, int jobId)
        {
            var job = await _context.Jobs.FindAsync(jobId);
            if (job == null)
                throw new Exception("Job not found.");

            var alreadyApplied = await _context.AppliedJobs
                .AnyAsync(a => a.UserId == userId && a.JobId == jobId);

            if (alreadyApplied)
                throw new Exception("User has already applied for this job.");

            var appliedJob = new AppliedJob
            {
                JobId = job.JObId,
                UserId = userId,
                JobTitle = job.JobTitle,
                Company = job.Company,
                Location = job.Location,
                AppliedJobDate = DateTime.Now
            };

            _context.AppliedJobs.Add(appliedJob);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Job>> GetAppliedJobsByUserIdAsync(int userId)
        {
            var appliedJobs = await _context.AppliedJobs
                .Where(a => a.UserId == userId)
                .ToListAsync();

            return appliedJobs.Select(a => new Job
            {
                JObId = a.JobId,
                JobTitle = a.JobTitle,
                Company = a.Company,
                Location = a.Location,
                PostedDate = a.AppliedJobDate
            }).ToList();
        }
    }
}
