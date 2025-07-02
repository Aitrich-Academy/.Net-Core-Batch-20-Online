using JobsManagement.Dto;
using JobsManagement.Interface;
using JobsManagement.Model;
using JobsManagement.Repository;

namespace JobsManagement.Services
{
    public class JobService: IJobService
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
