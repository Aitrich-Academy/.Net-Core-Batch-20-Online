using JobAppPortal.Models;

namespace JobAppPortal.Interface
{
    public interface IJobService
    {
        public List<Job> GetJobs();

        public List<Job> GetJobPosted(Guid cmpid);
    }
}
