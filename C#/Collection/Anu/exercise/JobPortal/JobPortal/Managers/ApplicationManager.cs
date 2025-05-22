using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Interfaces;
using JobPortal.Models;


namespace JobPortal.Managers
{
    public class ApplicationManager
    {
        private IApplicationRepository applicationRepository;
        public ApplicationManager(IApplicationRepository repository)
        {
            applicationRepository = repository;
        }
        public void ApplyToJob(Application application)
        {
            applicationRepository.AddApplication(application);
        }
        public List<Application> GetApplicationsByJob(int jobId)
        {
            return applicationRepository.GetApplicationsByJobId(jobId);
        }
        public List<Application> GetApplicationsByApplicant(string applicantUsername)
        {
            return applicationRepository.GetApplicationsByApplicant(applicantUsername);
        }
    }
}
