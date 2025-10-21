using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Admin.DTOs;
using Domain.Service.Admin.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Domain.Service.Admin
{
    public class AdminRepository : IAdminRepository
    {
        private readonly HireMeNowDbContext _context;
        public AdminRepository(HireMeNowDbContext context)
        {
            _context = context;

        }
        //Add Industry
        public void AddIndustry(Industry industry)
        {
            _context.Industries.Add(industry);
            _context.SaveChangesAsync();
        }
        //Get Industry

        public async Task<List<Industry>> GetAllIndustriesAsync()
        {
            return await _context.Industries.ToListAsync();
        }


        public async Task<Industry?> GetIndustryByIdAsync(Guid id)
        {
            return await _context.Industries.FindAsync(id);
            
        }

        //get IndustryCount
        public async Task<int> GetIndustryCountAsync()
        {
            return await _context.Industries.CountAsync();
        }


        //Edit Industry
        public async Task<Industry> UpdateIndustryAsync(Industry industry)
        {
            _context.Industries.Update(industry);
            await _context.SaveChangesAsync();
            return industry;
        }

        //patch Industry
        public async Task<Industry?> PatchIndustryAsync(Guid id, Industry updatedData)
        {
            var existing = await _context.Industries.FindAsync(id);
            if (existing == null)
                return null;

            

            if (!string.IsNullOrEmpty(updatedData.Description))
                existing.Description = updatedData.Description;

            await _context.SaveChangesAsync();
            return existing;
        }

        //Delete Industry
        public async Task<bool> DeleteIndustryAsync(Guid id)
        {
            var existing = await _context.Industries.FindAsync(id);
            if (existing == null)
                return false;

            _context.Industries.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }




        public async Task<IEnumerable<JobPost>> GetPendingJobsAsync()
        {
            return await _context.JobPosts
                .Where(j => j.Status == "Pending")
                .ToListAsync();
        }


        public async Task<bool> ApproveJobAsync(Guid jobId)
        {
            var job = await _context.JobPosts.FindAsync(jobId);
            if (job == null) return false;

            job.Status = "Approved";
            _context.JobPosts.Update(job);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RejectJobAsync(Guid jobId)
        {
            var job = await _context.JobPosts.FindAsync(jobId);
            if (job == null) return false;

            job.Status = "Rejected";
            _context.JobPosts.Update(job);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
