using System;
using Microsoft.EntityFrameworkCore;
using workshopmvc.Interface;
using workshopmvc.Models;

namespace workshopmvc.Repository
{
    public class JobRepository:IJobRepository
    {
        private readonly ApplicationDbContext _context;

        public JobRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Create(Job job)
        {
            _context.Job.AddAsync(job);

            _context.SaveChanges();

            return true;
        }
        public List<Job> GetJobPosted(Guid cmpid)
        {
            return _context.Job.Where(e => e.CompanyId == cmpid).Include(e => e.Company).ToList();
        }

        public List<Job> GetJobs()
        {
            return _context.Job.Include(e => e.Company).ToList();
        }


    }
}
