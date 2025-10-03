using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Extension;
using Domain.Models;
using Domain.Service.Job.DTO;
using Domain.Service.Job.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Domain.Service.Job
{
    public class JobRepository : IJobRepository
    {
        public readonly AppDbContext _context;
        IMapper _mapper;

        public JobRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<JobPost>> GetJobs()
        {
            return await _context.JobPosts
                    .Include(j => j.Location)
                    .Include(j => j.Industry)
                    .Include(j => j.JobCategory)
                    .ToListAsync();
        }


        public async Task<JobPost?> GetJobByIdAsync(Guid id)
        {
            return await _context.JobPosts
                .Include(j => j.Location)
                .Include(j => j.Industry)
                .Include(j => j.JobCategory)
                .FirstOrDefaultAsync(j => j.Id == id);
        }



        public async Task<AppliedJobs> ApplyJobAsync(AppliedJobs appliedJob)
        {
            await _context.AppliedJobs.AddAsync(appliedJob);
            await _context.SaveChangesAsync();
            return appliedJob;
        }


    }

    }
