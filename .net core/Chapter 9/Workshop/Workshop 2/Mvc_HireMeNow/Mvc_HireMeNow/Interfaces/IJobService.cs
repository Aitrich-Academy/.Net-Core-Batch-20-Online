

using Mvc_HireMeNow.Models;

namespace Mvc_HireMeNow.Interfaces
{
    public interface IJobService
    {
	

		
		public List<Job> GetJobs();
		public List<Job> GetJobsposted(Guid cmpId);
	
	}
}
