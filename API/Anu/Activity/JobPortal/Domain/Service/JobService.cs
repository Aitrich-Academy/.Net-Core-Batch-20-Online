using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Domain.Dto;
using AutoMapper;
using Domain.Helper;

namespace Domain.Service
{
    public class JobService : IJobService
    {
        public readonly IJobRepository _jobRepository;
        public readonly IMapper _mapper;

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
            var jobByid = await _jobRepository.GetJobByIdAsync(id);
            return _mapper.Map<JobDto>(jobByid);
        }

        public async Task<JobDto> AddJobAsync(JobDto jobdto)
        {
            var addjob = _mapper.Map<Job>(jobdto);
            addjob = await _jobRepository.AddJobAsync(addjob);
            return _mapper.Map<JobDto>(addjob);
        }

        public async Task<JobDto> UpdateJobAsync(JobDto jobdto)
        {
            var updatejob = _mapper.Map<Job>(jobdto);
            updatejob = await _jobRepository.UpdateJobAsync(updatejob);
            return _mapper.Map<JobDto>(updatejob);
        }

        public async Task<bool> DeleteJobAsync(int id)
        {
            return await _jobRepository.DeleteJobAsync(id);
        }
    }
}
