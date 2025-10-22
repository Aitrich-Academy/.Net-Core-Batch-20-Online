using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.JobProvider.Interfaces
{
    public interface IJobProviderRepository
    {

        // ================== JobProvider / Authentication ==================
        Task<JobProviderCompany?> GetJobProviderByIdAsync(Guid jobProviderId);
        Task<JobProviderCompany?> GetJobProviderByEmailAsync(string email);
        Task<JobProviderCompany> AddJobProviderAsync(JobProviderCompany jobProvider);
        Task<bool> EmailExistsAsync(string email);

        // ================== Email Verification / OTP ==================
        Task<EmailVerification> AddEmailVerificationAsync(EmailVerification verification);
        Task<EmailVerification?> GetEmailVerificationAsync(Guid jobProviderId, string otp);
        Task UpdateEmailVerificationAsync(EmailVerification verification);
        // ================== Profile Picture ==================
        Task AddProfilePictureAsync(Guid jobProviderId, string filePath);
        Task<string?> GetProfilePicturePathAsync(Guid jobProviderId);
        Task DeleteProfilePictureAsync(Guid jobProviderId);

        // ================== Company ==================
        Task<CompanyUser?> GetCompanyByIdAsync(Guid companyId);
        Task<IEnumerable<JobProviderCompany>> GetAllCompaniesAsync();
        Task<CompanyUser> AddCompanyAsync(CompanyUser company);
        Task UpdateCompanyAsync(CompanyUser company);
        Task DeleteCompanyAsync(CompanyUser company);

        // ================== Company Member ==================
        Task<CompanyUser?> GetCompanyMemberByIdAsync(Guid memberId);
        Task<IEnumerable<CompanyUser>> GetAllCompanyMembersAsync();
        Task<CompanyUser> AddCompanyMemberAsync(CompanyUser member);
        Task UpdateCompanyMemberAsync(CompanyUser member);
        Task DeleteCompanyMemberAsync(CompanyUser member);

        Task<JobProviderCompany?> GetByIdAsync(Guid jobProviderId);
        Task<string> LogoutAsync(Guid jobProviderId);

        // ================== Save Changes ==================
        Task<int> SaveChangesAsync();

      
    }
}