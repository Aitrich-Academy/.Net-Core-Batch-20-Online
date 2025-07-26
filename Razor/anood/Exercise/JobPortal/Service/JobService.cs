using AutoMapper;
using Hangfire.MemoryStorage.Dto;
using JobPortal.Dto;
using JobPortal.Interface;
using JobPortal.Model;
using JobPortal.Repository;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Service
{
    public class JobService : IJobService
    {
        private readonly JobRepository jobRepository;

        public JobService(JobRepository _jobRepository)
        {
            jobRepository = _jobRepository;
        }

        public async Task<List<Jobs>> GetAllJobsAsync()
        {
            return await jobRepository.GetAllJobsAsync();
        }

        public async Task AddJobsAsync(JobsDto jobsDto)
        {
            await jobRepository.AddJobsAsync(jobsDto);
        }

        public async Task ApplyToJobAsync(int userId, int jobId)
        {
            await jobRepository.ApplyToJobAsync(userId, jobId);
        } 

       

        public async Task<Jobs> GetJobByIdAsync(int id)
        {
            return await jobRepository.GetJobByIdAsync(id);
        }

    }
}
