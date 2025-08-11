using HireMeNowMVC.Models;

namespace HireMeNowMVC.Interface
{
    public interface IJobService
    {

        public List<Job> GetJobs();

        public List<Job> GetJobPosted(Guid cmpid);
    }
}
