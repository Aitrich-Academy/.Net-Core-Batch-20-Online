using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.JobProvider.Dto;
using JobSeekerModel = Domain.Models.JobSeeker;

namespace Domain.Service.JobProvider.Interfaces
{
    public interface IJobProviderService
    {
        // -------------------------
        // JOB SEEKER METHODS
        // -------------------------
        Task<List<JobSeekerDto>> GetJobSeekersAsync();
        Task<JobSeekerDto?> GetJobSeekerByIdAsync(Guid id);
        Task<List<JobSeekerDto>> GetJobSeekersByTitleAsync(string title);

        // -------------------------
        // JOB POST METHODS
        // -------------------------
        Task<Guid> CreateJobPostAsync(JobPostDto jobPost);
        Task<JobPostDto?> GetJobByIdAsync(Guid id);
        Task<bool> UpdateJobByIdAsync(Guid id, JobPostDto updatedJob);
        Task<bool> PatchJobByIdAsync(Guid id, decimal? salary);
        Task<bool> DeleteJobByIdAsync(Guid id);
        Task<List<JobPostDto>> GetAllJobsAsync();
        Task<int> GetApplicationCountAsync();
    }
}
