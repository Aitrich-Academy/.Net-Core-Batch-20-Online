

using Mvc_HireMeNow.Models;

namespace Mvc_HireMeNow.Interfaces
{
    public interface IJobRepository
    {
	
		bool Create(Job job);
		public List<Job> GetJobsposted(Guid cmpId);
		
		List<Job> GetJobs();
		
	}
}
