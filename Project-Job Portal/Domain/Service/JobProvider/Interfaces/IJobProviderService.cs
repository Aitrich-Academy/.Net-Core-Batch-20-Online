using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.AspNetCore.Http;

namespace Domain.Service.JobProvider.Interfaces
{
    public interface IJobProviderService
    {
        // ================== Authentication ==================
        Task<(Guid JobProviderId, string Message)> RegisterAsync(string name, string email, string password);
        Task<(string Token, Guid JobProviderId, string Message)> LoginAsync(string email, string password);

        Task<string> SendOtpAsync(Guid jobProviderId);             // Send OTP to JobProvider's email
        Task<string> VerifyOtpAsync(Guid jobProviderId, string otp); // Verify OTP using JobProviderId


        // ================== Profile Picture ==================
        Task<string> AddProfilePictureAsync(Guid jobProviderId, IFormFile file);
        Task<string> UpdateProfilePictureAsync(Guid jobProviderId, IFormFile file);
        Task<string> DeleteProfilePictureAsync(Guid jobProviderId);
        Task<string> GetProfilePictureAsync(Guid jobProviderId);

        // ================== Company ==================
        Task<(Guid CompanyId, string Message)> AddCompanyAsync(Guid jobProviderId, string companyName, string location, string industry, string websiteUrl);
        Task<JobProviderCompany> GetCompanyByIdAsync(Guid companyId);

        Task<IEnumerable<JobProviderCompany>> GetAllCompaniesAsync();
        Task<string> UpdateCompanyByIdAsync(Guid companyId, string companyName, string location, string industry, string websiteUrl);
        Task<string> PatchCompanyByIdAsync(Guid companyId, string industry);
        Task<string> DeleteCompanyByIdAsync(Guid companyId);

        // ================== Company Member ==================
        Task<(Guid MemberId, string Message)> AddCompanyMemberAsync(Guid companyId, string memberName, string designation, string email, string phone);

        Task<IEnumerable<CompanyUser>> GetAllCompanyMembersAsync();

        Task<CompanyUser> GetCompanyMemberByIdAsync(Guid memberId);
        Task<string> UpdateCompanyMemberAsync(Guid memberId, string memberName, string designation, string email, string phone);
        Task<string> PatchCompanyMemberAsync(Guid memberId, string designation);
        Task<string> DeleteCompanyMemberAsync(Guid memberId);

        Task<string> LogoutAsync(Guid jobProviderId);

    }
}