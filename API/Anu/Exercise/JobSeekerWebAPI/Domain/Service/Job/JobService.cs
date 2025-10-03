using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Extension;
using Domain.Models;
using Domain.Service.Job.DTO;

//using Domain.Service.Job.DTO;
using Domain.Service.Job.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Domain.Service.Job
{
    public class JobService :IJobService
    {

       public readonly  IJobRepository  _jobRepository;
        public  readonly  IMapper _mapper;
        public readonly AppDbContext _context;

        public JobService(IJobRepository jobRepository, IMapper mapper,AppDbContext context)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;
            _context = context;
        }

        public async Task<List<JobPost>> GetJobs()
        {
            return await _jobRepository.GetJobs();
        }

     

        public async Task<Joblist?> GetJobByIdAsync(Guid id)
        {
            var job = await _jobRepository.GetJobByIdAsync(id);
            if (job == null) return null;
 
            return new Joblist
            {
                Id = job.Id,
                JobTitle = job.JobTitle,
                JobSummary = job.JobSummary,
                Company = job.Company,
                LocationName = job.Location.Name,
                IndustryName = job.Industry.Name,
                JobCategoryName = job.JobCategory.Name,
                PostedDate = job.PostedDate
            };
        }

        public async Task<bool> ApplyJobAsync(AppliedJobDto dto)
        {
            var entity = _mapper.Map<AppliedJobs>(dto);
            entity.Id = Guid.NewGuid();  
            entity.DateSaved = DateTime.UtcNow;
            

            var saved = await _jobRepository.ApplyJobAsync(entity);

            return true; //_mapper.Map<AppliedJobDto>(saved);
        }

        public async Task<bool> ExistsAsync(Guid jobId, Guid userId)
        {
            return await _context.AppliedJobs
                .AnyAsync(a => a.Job == jobId && a.SavedBy == userId);
        }


    }
}
 