using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;
using JobSeekerModel = Domain.Models.JobSeeker; // alias to fix naming conflict

namespace Domain.Service.JobProvider.Interfaces
{
    public interface IJobProviderRepository
    {
        // -------------------------
        // JOB SEEKER METHODS
        // -------------------------

        // 18. Get all Job Seekers
        Task<List<JobSeekerModel>> GetJobSeekersAsync();

        // 19. Get Job Seeker By ID
        Task<JobSeekerModel?> GetJobSeekerByIdAsync(Guid id);

        // 20. Get Job Seekers By Title
        Task<List<JobSeekerModel>> GetJobSeekersByTitleAsync(string title);


        // -------------------------
        // JOB POST METHODS
        // -------------------------

        // 21. Create Job Post
        Task<Guid> CreateJobPostAsync(JobPost jobPost);

        // 22. Get Job By ID
        Task<JobPost?> GetJobByIdAsync(Guid id);

        // 23. Update Job By ID
        Task<bool> UpdateJobByIdAsync(Guid id, JobPost updatedJob);

        // 24. Patch Job By ID (partial update — e.g., salary only)
        Task<bool> PatchJobByIdAsync(Guid id, decimal? salary);

        // 25. Delete Job By ID
        Task<bool> DeleteJobByIdAsync(Guid id);

        // 26. Get All Jobs
        Task<List<JobPost>> GetAllJobsAsync();

        // 27. Get Application Count
        Task<int> GetApplicationCountAsync();
    }
}