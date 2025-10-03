using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Job.DTO;

namespace Domain.Service.Job.Interface
{
    public interface IJobRepository
    {
        public Task<List<JobPost>> GetJobs();
        Task<JobPost?> GetJobByIdAsync(Guid id);

        Task<AppliedJobs> ApplyJobAsync(AppliedJobs appliedJob);
    }
}
