using workshopmvc.Interface;
using workshopmvc.Models;

namespace workshopmvc.Services
{
    public class JobService:IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public List<Job> GetJobPosted(Guid cmpid)
        {
            return _jobRepository.GetJobPosted(cmpid);
        }

        public List<Job> GetJobs()
        {
            return _jobRepository.GetJobs();
        }
    }
}
