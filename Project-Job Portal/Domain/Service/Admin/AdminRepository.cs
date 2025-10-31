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
        //public async Task<Industry?> PatchIndustryAsync(Guid id, Industry updatedData)
        //{
        //    var existing = await _context.Industries.FindAsync(id);
        //    if (existing == null)
        //        return null;

        //    if (!string.IsNullOrEmpty(updatedData.Name))
        //        existing.Name= updatedData.Name;

        //    if (!string.IsNullOrEmpty(updatedData.Description) )
        //        existing.Description = updatedData.Description;
        //    _context.Industries.Update(existing);
        //    await _context.SaveChangesAsync();
        //    return existing;
        //}
        public async Task<bool> PatchIndustryAsync(Industry updatedData)
        {
            _context.Industries.Update(updatedData);
            await _context.SaveChangesAsync();
            return true;
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


        //Add Category
        public async Task<JobCategory> AddJobCategoryAsync(JobCategory category)
        {
            _context.JobCategories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }


        //GetAllCategory
        public async Task<IEnumerable<JobCategory>> GetAllJobCategoryAsync()
        {
            return await _context.JobCategories.ToListAsync();
        }

        //GetCategoryById
        public async Task<JobCategory?> GetJobCategoryByIdAsync(Guid id)
        {
            return await _context.JobCategories.FindAsync(id);
        }


        //updateJobCategory
        public async Task<bool> UpdateJobCategoryAsync(JobCategory category)
        {
            _context.JobCategories.Update(category);
            return await _context.SaveChangesAsync() > 0;
        }

        //PatchJobCategory
        public async Task<bool> PatchJobCategoryAsync( JobCategory category)
        {


            _context.JobCategories.Update(category);
            await _context.SaveChangesAsync();
            return true;
        }

        //Delete JobCategory
        public async Task<bool> DeleteJobCategoryAsync(Guid id)
        {
            var existing = await _context.JobCategories.FindAsync(id);
            if (existing == null)
                return false;

            _context.JobCategories.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<int> GetJobCountAsync()
        {
            return await _context.JobPosts.CountAsync();
        }

        public async Task<JobPost?> GetJobByNameAsync(string jobTitle)
        {
            

            var Job = await _context.JobPosts.FirstOrDefaultAsync(x => x.JobTitle == jobTitle);
            return Job;
        }


        public async Task<IEnumerable<JobProviderCompany>> GetAllProviders()
        {
            return await _context.JobProviderCompanies.ToListAsync();
        }


        public async Task<JobProviderCompany?> GetJobProviderByIdAsync(Guid id)
        {
            return await _context.JobProviderCompanies.FindAsync(id);

        }

        public async Task<int> GetJobProviderCountAsync()
        {
            return await _context.JobProviderCompanies.CountAsync();
        }


        //Delete Industry
        public async Task<bool> DeleteJobProviderAsync(Guid id)
        {
            var existing = await _context.JobProviderCompanies.FindAsync(id);
            if (existing == null)
                return false;

            _context.JobProviderCompanies.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }

    }



   
    }
