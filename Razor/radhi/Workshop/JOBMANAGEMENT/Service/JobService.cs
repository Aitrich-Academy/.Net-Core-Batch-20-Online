using JOBMANAGEMENT.Dto;
using JOBMANAGEMENT.Interface;
using JOBMANAGEMENT.Models;
using JOBMANAGEMENT.Repository;

namespace JOBMANAGEMENT.Service
{
    public class JobService:IJobService
    {
        private readonly JobRepository jobRepository;

        public JobService(JobRepository _jobRepository)
        {
            jobRepository = _jobRepository;
        }

        public async Task<List<Job>> GetAllJobsAsync()
        {
            return await jobRepository.GetAllJobsAsync();
        }

        public async Task<Job> GetJobByIdAsync(int id)
        {
            return await jobRepository.GetJobByIdAsync(id);
        }

        public async Task AddJobAsync(JobDto jobDto)
        {
            await jobRepository.AddJobAsync(jobDto);
        }

        public async Task UpdateJobAsync(int id, Job jobDto)
        {
            await jobRepository.UpdateJobAsync(id, jobDto);
        }

        public async Task DeleteJobAsync(int id)
        {
            await jobRepository.DeleteJobAsync(id);
        }
    }
}

