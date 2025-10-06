using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Dto;

namespace Domain.Interface
{
    public interface IJobService
    {
        Task<JobDto> CreateJobAsync(JobDto jobDto);
        Task<IEnumerable<JobDto>> GetAllJobsAsync();
        Task<JobDto> GetJobByIdAsync(int id);
        Task<JobDto> UpdateJobAsync(int id, JobDto jobDto);
        Task<bool> DeleteJobAsync(int id);
    }
}
