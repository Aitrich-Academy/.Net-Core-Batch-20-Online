using AutoMapper;
using JobApi.Interface;
using JobApi.Models;
using JobPortalAPI.DTOs;
using Microsoft.EntityFrameworkCore;

namespace JobApi.Service
{
    public class JobService:IJobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;

        public JobService(IJobRepository jobRepository, IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<JobDTO>> GetJobsAsync()
        {
            var jobs = await _jobRepository.GetJobsAsync();
            return _mapper.Map<IEnumerable<JobDTO>>(jobs);
        }

        public async Task<JobDTO> GetJobByIdAsync(int id)
        {
            var job = await _jobRepository.GetJobByIdAsync(id);
            return _mapper.Map<JobDTO>(job);
        }

        public async Task<JobDTO> AddJobAsync(JobDTO jobDto, int userId)
        {
            var job = _mapper.Map<Job>(jobDto);

            // Link the job to the logged-in user
            job.UserId = userId;

            job = await _jobRepository.AddJobAsync(job, userId);
            return _mapper.Map<JobDTO>(job);
        }

        public async Task<JobDTO> UpdateJobAsync(int jobId, JobDTO jobDto, int userId)
        {
            // Get the job from repository
            var job = await _jobRepository.GetJobByIdAndUserAsync(jobId, userId);
            if (job == null) return null;

            // Update properties
            job.Title = jobDto.Title;
            job.Description = jobDto.Description;
            job.Company = jobDto.Company;
            job.Salary = jobDto.Salary;
            job.Location = jobDto.Location;

            // Save changes via repository
            await _jobRepository.UpdateJobAsync(job);

            // Return DTO
            return new JobDTO
            {
                Title = job.Title,
                Description = job.Description,
                Company = job.Company,
                Salary = job.Salary,
                Location = job.Location
            };
         }

        public async Task<bool> DeleteJobAsync(int jobId, int userId)
        {
            return await _jobRepository.DeleteJobAsync(jobId, userId);
        }
    }
}
