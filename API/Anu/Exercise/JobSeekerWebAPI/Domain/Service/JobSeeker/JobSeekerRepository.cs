using AutoMapper;

using Domain.Models;
using Domain.Service.JobSeeker.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Extension;
using Domain.Service.Job.DTO;
using Domain.Service.JobSeeker.DTO;

namespace Domain.Service.JobSeeker
{
    public class JobSeekerRepository :IJobSeekerRepository 
    {
        AppDbContext  _context;
        IMapper _mapper;

        public JobSeekerRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<RegisterUser> ViewSeekerByIdAsync(Guid id)
        {
            return await _context.RegisterUsers.FindAsync(id);
        }

        public async Task<RegisterUser> UpdateSeekerAsync(RegisterUser reguser)
        {
            _context.RegisterUsers.Update(reguser);
            await _context.SaveChangesAsync();
            return reguser;
        }

        public async Task<List<ViewappliedDto>> GetAppliedJobsByUserAsync(Guid userId)
        {
            return await _context.AppliedJobs
                .Where(a => a.SavedBy == userId)
                .Select(a => new ViewappliedDto
                {
                    Id = a.Id,
                    DateSaved = a.DateSaved,
                    Status = a.Status,
                    JobId = a.JobPost.Id,
                    JobTitle = a.JobPost.JobTitle,
                    Company = a.JobPost.Company,
                    Location = a.JobPost.Location.Name,
                    Industry = a.JobPost.Industry.Name,
                    Category = a.JobPost.JobCategory.Name
                })
                .ToListAsync();
        }
    }
}
