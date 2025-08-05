
using Microsoft.EntityFrameworkCore;
using Mvc_HireMeNow.Interfaces;
using Mvc_HireMeNow.Models;

namespace Mvc_HireMeNow.Data.Repositories
{
	public class JobRepository : IJobRepository
	{
		HireMeNowDbContext _context = new HireMeNowDbContext();
        public JobRepository(HireMeNowDbContext context)
        {
			_context = context;
        }
      
		 
		public List<Job>GetJobs()
		{
			return _context.Jobs.Include(e=>e.Company).ToList();
		}
		public bool  Create(Job job)
		{
			 _context.Jobs.AddAsync(job);
			_context.SaveChanges();
			return true;
		}
		public List<Job> GetJobsposted(Guid cmpId)
		{
			return _context.Jobs.Where(e=>e.CompanyId==cmpId).Include(e => e.Company).ToList();
		}
	}
}
