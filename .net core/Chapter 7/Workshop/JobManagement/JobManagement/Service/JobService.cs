using AutoMapper;
using JobManagement.Dto;
using JobManagement.Interface;
using JobManagement.Model;
using JobManagement.Repository;
using Microsoft.EntityFrameworkCore;

namespace JobManagement.Service
{
    public class JobService:IJobService
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

        public async Task<Jobs> GetJobByIdAsync(int id)
        {
           return await jobRepository.GetJobByIdAsync(id);
        }

        public async Task AddJobAsync(JobDto jobDto)
        {
            await jobRepository.AddJobAsync(jobDto);
        }

        public async Task UpdateJobAsync(int id, Jobs jobDto)
        {
            await jobRepository.UpdateJobAsync(id, jobDto);
        }

        public async Task DeleteJobAsync(int id)
        {
            await jobRepository.DeleteJobAsync(id);
        }
    }
}
