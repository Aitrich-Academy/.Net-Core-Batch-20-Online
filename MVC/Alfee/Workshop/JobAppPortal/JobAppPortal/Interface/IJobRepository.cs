using JobAppPortal.Models;

namespace JobAppPortal.Interface
{
    public interface IJobRepository
    {
        bool Create(Job job);
        public List<Job> GetJobs();

        public List<Job> GetJobPosted(Guid cmpid);
    }
}
