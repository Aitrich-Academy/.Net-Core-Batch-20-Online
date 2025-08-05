
using Mvc_HireMeNow.Data.Repositories;
using Mvc_HireMeNow.Interfaces;
using Mvc_HireMeNow.Models;

namespace Mvc_HireMeNow.Services
{
	public class JobService : IJobService
	{
		IJobRepository _jobRepository;
		public JobService(IJobRepository jobRepository)
        {
			_jobRepository = jobRepository;
		}
       
		public List<Job> GetJobs()
		{
			return _jobRepository.GetJobs();
		}
		public List<Job> GetJobsposted(Guid cmpId)
		{
			return _jobRepository.GetJobsposted(cmpId);
		}

	}
}
