using Domain.Models;
using Domain.Service.JobProvider.Interfaces;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using JobSeekerModel = Domain.Models.JobSeeker; // <--- Alias fix

namespace Domain.Service.JobProvider
{
    public class JobProviderRepository : IJobProviderRepository
    {
        private readonly HireMeNowDbContext _context;
        private readonly IMapper _mapper;

        public JobProviderRepository(HireMeNowDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

      

        // ================== Profile Picture ==================
        public async Task AddProfilePictureAsync(Guid jobProviderId, string filePath)
        {
            // You can store the path in a column in JobProviderCompany if needed
            // Example: _context.JobProviderCompanies.Find(jobProviderId).ProfilePicturePath = filePath;+
            await Task.CompletedTask;
        }

        public async Task<string?> GetProfilePicturePathAsync(Guid jobProviderId)
        {
            // Example: return _context.JobProviderCompanies.Find(jobProviderId)?.ProfilePicturePath;
            return await Task.FromResult<string?>(null);
        }

        public async Task DeleteProfilePictureAsync(Guid jobProviderId)
        {
            // Implement file deletion logic here if stored
            await Task.CompletedTask;
        }

        // ================== Company ==================
        public async Task<CompanyUser?> GetCompanyByIdAsync(Guid companyId)
        {
            return await _context.CompanyUsers
                .Include(c => c.CompanyNavigation)
                .FirstOrDefaultAsync(c => c.Id == companyId);
        }

        public async Task<IEnumerable<JobProviderCompany>> GetAllCompaniesAsync()
        {
            return await _context.JobProviderCompanies
                .Include(c => c.LocationNavigation)
                .Include(c => c.CompanyUsers)
                .ToListAsync();
        }


        public async Task<CompanyUser> AddCompanyAsync(CompanyUser company)
        {
            _context.CompanyUsers.Add(company);
            await _context.SaveChangesAsync();
            return company;
        }

        public async Task UpdateCompanyAsync(CompanyUser company)
        {
            _context.CompanyUsers.Update(company);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCompanyAsync(CompanyUser company)
        {
            _context.CompanyUsers.Remove(company);
            await _context.SaveChangesAsync();
        }

        // ================== Company Member ==================
        public async Task<CompanyUser?> GetCompanyMemberByIdAsync(Guid memberId)
        {
            return await _context.CompanyUsers
                .Include(c => c.CompanyNavigation)
                .FirstOrDefaultAsync(c => c.Id == memberId);
        }

        public async Task<IEnumerable<CompanyUser>> GetAllCompanyMembersAsync()
        {
            return await _context.CompanyUsers
                .Include(m => m.CompanyNavigation)
                .ToListAsync();
        }


        public async Task<CompanyUser> AddCompanyMemberAsync(CompanyUser member)
        {
            _context.CompanyUsers.Add(member);
            await _context.SaveChangesAsync();
            return member;
        }

        public async Task UpdateCompanyMemberAsync(CompanyUser member)
        {
            _context.CompanyUsers.Update(member);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCompanyMemberAsync(CompanyUser member)
        {
            _context.CompanyUsers.Remove(member);
            await _context.SaveChangesAsync();
        }

        public async Task<JobProviderCompany?> GetByIdAsync(Guid jobProviderId)
        {
            return await _context.JobProviderCompanies.FindAsync(jobProviderId);
        }

        public async Task<string> LogoutAsync(Guid jobProviderId)
        {
            var jobProvider = await _context.JobProviderCompanies.FindAsync(jobProviderId);
            if (jobProvider == null)
                return "Job provider not found.";

            // No token state change required — JWT is client-side
            return "Logout successful. Please clear your token on the client side.";

        }
        // ================== Save Changes ==================
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }



        //// -------------------------
        //// JOB POST METHODS
        //// -------------------------

        //public async Task<Guid> CreateJobPostAsync(JobPost jobPost)
        //{
        //    jobPost.Id = Guid.NewGuid();
        //    jobPost.PostedDate = DateTime.UtcNow;

        //    await _context.JobPosts.AddAsync(jobPost);
        //    await _context.SaveChangesAsync();

        //    return jobPost.Id;
        //}

        //public async Task<JobPost?> GetJobByIdAsync(Guid id)
        //{
        //    return await _context.JobPosts
        //                         .Include(jp => jp.Company)
        //                         .Include(jp => jp.Location)
        //                         //.Include(jp => jp.Category)
        //                         .Include(jp => jp.Industry)
        //                         .Include(jp => jp.JobResponsibilities)
        //                         .FirstOrDefaultAsync(jp => jp.Id == id);
        //}

        //public async Task<bool> UpdateJobByIdAsync(Guid id, JobPost updatedJob)
        //{
        //    var existingJob = await _context.JobPosts.FindAsync(id);
        //    if (existingJob == null) return false;

        //    // Only update fields present in updatedJob
        //    if (!string.IsNullOrEmpty(updatedJob.JobTitle))
        //        existingJob.JobTitle = updatedJob.JobTitle;

        //    if (!string.IsNullOrEmpty(updatedJob.JobSummary))
        //        existingJob.JobSummary = updatedJob.JobSummary;

        //    if (updatedJob.LocationId != Guid.Empty)
        //        existingJob.LocationId = updatedJob.LocationId;

        //    if (updatedJob.IndustryId != Guid.Empty)
        //        existingJob.IndustryId = updatedJob.IndustryId;

        //    await _context.SaveChangesAsync();
        //    return true;
        //}

        //public async Task<bool> PatchJobByIdAsync(Guid id, decimal? salary)
        //{
        //    var existingJob = await _context.JobPosts.FindAsync(id);
        //    if (existingJob == null) return false;

        //    if (salary.HasValue)
        //        existingJob.Salary = salary.Value;

        //    await _context.SaveChangesAsync();
        //    return true;
        //}

        //public async Task<bool> DeleteJobByIdAsync(Guid id)
        //{
        //    var existingJob = await _context.JobPosts.FindAsync(id);
        //    if (existingJob == null) return false;

        //    _context.JobPosts.Remove(existingJob);
        //    await _context.SaveChangesAsync();
        //    return true;
        //}

        //public async Task<List<JobPost>> GetAllJobsAsync()
        //{
        //    return await _context.JobPosts
        //                         .Include(jp => jp.Company)
        //                         .Include(jp => jp.Location)
        //                         .Include(jp => jp.Industry)
        //                         .ToListAsync();
        //}

        // -------------------------
        // JOB APPLICATION METHODS
        // -------------------------


        public async Task<List<JobApplication>> GetApplicantsByJobIdAsync(Guid jobId)
        {
            return await _context.JobApplications
                                 .Include(a => a.Seeker)      // ✅ Include navigation, not ID
                                 .Include(a => a.JobPost)
                                     // optional: if you need resume info too
                                 .Where(a => a.JobPostId == jobId)
                                 .ToListAsync();
        }

        public async Task<JobApplication?> GetApplicantByApplicationIdAsync(Guid applicationId)
        {
            return await _context.JobApplications
                                 .Include(a => a.Seeker)      // ✅ Include navigation
                                 .Include(a => a.JobPost)
                                   // optional
                                 .FirstOrDefaultAsync(a => a.Id == applicationId);
        }


        public async Task<int> GetApplicationCountAsync()
        {
            return await _context.JobApplications.CountAsync();
        }
    }
}
