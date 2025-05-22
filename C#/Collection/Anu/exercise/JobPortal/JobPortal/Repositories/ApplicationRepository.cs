using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Interfaces;
using JobPortal.Models;

namespace JobPortal.Repositories
{
    public class ApplicationRepository : IApplicationRepository
    {
        private List<Application> applications = new List<Application>();

        public void AddApplication(Application application)
        {
            applications.Add(application);
        }

        public List<Application> GetApplicationsByJobId(int jobId)
        {
            return applications.Where(a => a.JobId == jobId).ToList();
        }

        public List<Application> GetApplicationsByApplicant(string applicantUsername)
        {
            return applications.Where(a => a.ApplicantUsername == applicantUsername).ToList();
        }
    }
}
