using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Dto;
using Domain.Model;

namespace Domain.Interface
{
    public interface IJobService
    {
        Task<IEnumerable<JobDto>> GetAllJobsAsync();
        Task<JobDto> GetJobByIdAsync(int id);
        Task<JobDto> AddJobAsync(JobDto jobDto);
        Task<JobDto> UpdateJobAsync(JobDto jobDto);
        Task<bool> DeleteJobAsync(int id);
    }
}
