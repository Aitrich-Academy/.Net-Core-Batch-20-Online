using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobPortal.Models;

namespace JobPortal.Interfaces
{
    public interface IApplicant : IUser
    {
        List<Job> SavedJobs { get; set; }
        List<Application> Applications { get; set; }
    }
}
