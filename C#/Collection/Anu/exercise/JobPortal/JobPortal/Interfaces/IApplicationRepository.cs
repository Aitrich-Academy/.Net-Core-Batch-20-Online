using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Models;

namespace JobPortal.Interfaces
{
    public interface IApplicationRepository
    {
        void AddApplication(Application application);
        List<Application> GetApplicationsByJobId(int jobId);
        List<Application> GetApplicationsByApplicant(string applicantUsername);
    }
}
