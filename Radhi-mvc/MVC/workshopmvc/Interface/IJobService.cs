using workshopmvc.Models;

namespace workshopmvc.Interface
{
    public interface IJobService
    {
        public List<Job> GetJobs();

        public List<Job> GetJobPosted(Guid cmpid);
    }
}
