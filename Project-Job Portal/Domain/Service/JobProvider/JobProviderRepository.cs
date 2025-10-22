using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.JobProvider.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using static System.Net.WebRequestMethods;

namespace Domain.Service.JobProvider
{
    public class JobProviderRepository : IJobProviderRepository
    {
        private readonly HireMeNowDbContext _context;

        public JobProviderRepository(HireMeNowDbContext context)
        {
            _context = context;
        }

        // ================== JobProvider / Authentication ==================
        public async Task<JobProviderCompany?> GetJobProviderByIdAsync(Guid jobProviderId)
        {
            return await _context.JobProviderCompanies
                .Include(jp => jp.CompanyUsers)
                .Include(jp => jp.JobPosts)
                .FirstOrDefaultAsync(jp => jp.Id == jobProviderId);
        }

        public async Task<JobProviderCompany?> GetJobProviderByEmailAsync(string email)
        {
            return await _context.JobProviderCompanies.FirstOrDefaultAsync(jp => jp.Email == email);
        }

        public async Task<JobProviderCompany> AddJobProviderAsync(JobProviderCompany jobProvider)
        {
            _context.JobProviderCompanies.Add(jobProvider);
            await _context.SaveChangesAsync();
            return jobProvider;
        }

        public async Task<bool> EmailExistsAsync(string email)
        {
            return await _context.JobProviderCompanies.AnyAsync(jp => jp.Email == email);
        }

        // ================== Email Verification / OTP ==================
        public async Task<EmailVerification> AddEmailVerificationAsync(EmailVerification verification)
        {
            _context.EmailVerifications.Add(verification);
            await _context.SaveChangesAsync();
            return verification;
        }

        public async Task<EmailVerification?> GetEmailVerificationAsync(Guid jobProviderId, string otp)
        {
            return await _context.EmailVerifications
                .Where(ev => ev.JobProviderId == jobProviderId && ev.OTP == otp)
                .OrderByDescending(ev => ev.CreatedAt)
                .FirstOrDefaultAsync();
        }

        public async Task UpdateEmailVerificationAsync(EmailVerification verification)
        {
            _context.EmailVerifications.Update(verification);
            await _context.SaveChangesAsync();
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
    }
}