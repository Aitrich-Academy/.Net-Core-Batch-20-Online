using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Job.DTO;
using Domain.Service.Job.DTO;

namespace Domain.Service.Job.Interface
{
    public interface IJobService
    {
        public Task<List<JobPost>> GetJobs();

        Task<Joblist?> GetJobByIdAsync(Guid id);

        Task<bool> ApplyJobAsync(AppliedJobDto request);

        Task <bool> ExistsAsync(Guid jobid,Guid seekerid);
    }
}
