using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Dto;
using Domain.Interface;
using Domain.Model;

namespace Domain.Service
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;
        private readonly IMapper _mapper;
        public JobService(IJobRepository jobRepository, IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<JobDto>> GetAllJobsAsync()
        {
            var jobs = await _jobRepository.GetAllJobsAsync();
            return _mapper.Map<IEnumerable<JobDto>>(jobs);
        }

        public async Task<JobDto> GetJobByIdAsync(int id)
        {
            var job = await _jobRepository.GetJobByIdAsync(id);
            return _mapper.Map<JobDto>(job);
        }

        public async Task<JobDto> AddJobAsync(JobDto jobDto)
        {
            var job = _mapper.Map<Job>(jobDto);
            var addedJob = await _jobRepository.AddJobAsync(job);
            return _mapper.Map<JobDto>(addedJob);
        }

        public async Task<JobDto> UpdateJobAsync(JobDto jobDto)
        {
            var job = _mapper.Map<Job>(jobDto);
            var updatedJob = await _jobRepository.UpdateJobAsync(job);
            return _mapper.Map<JobDto>(updatedJob);
        }

        public async Task<bool> DeleteJobAsync(int id)
        {
            var deletedJob = await _jobRepository.DeleteJobAsync(id);
            return deletedJob != null;
        }
    }
}
