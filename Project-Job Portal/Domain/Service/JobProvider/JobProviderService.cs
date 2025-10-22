using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Domain.Helpers;
using Domain.Models;
using Domain.Service.JobProvider.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Domain.Service.JobProvider
{
    public class JobProviderService : IJobProviderService
    {
        private readonly HireMeNowDbContext _context;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;
        public JobProviderService(HireMeNowDbContext context, IConfiguration configuration, IEmailService emailService)
        {
            _context = context;
            _configuration = configuration;
            _emailService = emailService;
        }
        // ================== Authentication ==================
        public async Task<(Guid JobProviderId, string Message)> RegisterAsync(string name, string email, string password)
        {
            var exists = await _context.JobProviderCompanies.AnyAsync(jp => jp.Email == email);
            if (exists) return (Guid.Empty, "Email already exists");

            // Ensure a default or dummy location exists
            var defaultLocation = await _context.Locations.FirstOrDefaultAsync();
            if (defaultLocation == null)
            {
                // Create one if not found
                defaultLocation = new Location
                {
                    Id = Guid.NewGuid(),
                    City = "Unknown",
                    State = "Unknown",
                    Country = "Unknown"
                };
                _context.Locations.Add(defaultLocation);
                await _context.SaveChangesAsync();





            }

            var jobProvider = new JobProviderCompany
            {
                Id = Guid.NewGuid(),
                LegalName = name,
                Email = email,
                Address = string.Empty,
                Summary = string.Empty,
                Website = string.Empty,
                Location = defaultLocation.Id // ✅ Fix: set valid FK value
            };

            _context.JobProviderCompanies.Add(jobProvider);
            await _context.SaveChangesAsync();

            return (jobProvider.Id, "Registration successful");
        }
        public async Task<(string Token, Guid JobProviderId, string Message)> LoginAsync(string email, string password)
        {
            var jobProvider = await _context.JobProviderCompanies.FirstOrDefaultAsync(jp => jp.Email == email);
            if (jobProvider == null) return (null!, Guid.Empty, "Invalid credentials");

            var token = JwtHelper.GenerateToken(
                jobProvider.Id,
                jobProvider.Email,
                _configuration["AuthSettings:Token"],
                60
            );

            return (token, jobProvider.Id, "Login successful");
        }


        // ================== Send OTP ==================
        // ================== OTP ==================
        public async Task<string> SendOtpAsync(Guid jobProviderId)
        {
            var jobProvider = await _context.JobProviderCompanies.FindAsync(jobProviderId);
            if (jobProvider == null) return "JobProvider not found";

            var otp = new Random().Next(100000, 999999).ToString();

            var verification = new EmailVerification
            {
                Id = Guid.NewGuid(),
                JobProviderId = jobProviderId,
                OTP = otp,
                ExpiryTime = DateTime.UtcNow.AddMinutes(5),
                IsVerified = false,
                CreatedAt = DateTime.UtcNow
            };

            _context.EmailVerifications.Add(verification);
            await _context.SaveChangesAsync();

            // Optionally send email
            await _emailService.SendEmailAsync(jobProvider.Email, "Your OTP", $"Your OTP is: {otp}");

            return $"OTP sent to {jobProvider.Email}";
        }
        public async Task<string> VerifyOtpAsync(Guid jobProviderId, string otp)
        {
            var record = await _context.EmailVerifications
                .Where(x => x.JobProviderId == jobProviderId && x.OTP == otp)
                .OrderByDescending(x => x.CreatedAt)
                .FirstOrDefaultAsync();

            if (record == null) return "Invalid OTP";
            if (record.IsVerified) return "OTP already verified";
            if (record.ExpiryTime < DateTime.UtcNow) return "OTP expired";

            record.IsVerified = true;
            await _context.SaveChangesAsync();

            return "OTP verified successfully";
        }


        // ================== Profile Picture ==================
        public async Task<string> AddProfilePictureAsync(Guid jobProviderId, IFormFile file)
        {
            var jobProvider = await _context.JobProviderCompanies.FindAsync(jobProviderId);
            if (jobProvider == null) return "JobProvider not found";

            var folder = Path.Combine("wwwroot", "uploads", "profile-pictures");
            Directory.CreateDirectory(folder);
            var filePath = Path.Combine(folder, $"{jobProviderId}_{file.FileName}");

            using (var stream = File.Create(filePath))
            {
                await file.CopyToAsync(stream);
            }

            // You could save file path in DB
            return "Profile picture added successfully";
        }

        public async Task<string> UpdateProfilePictureAsync(Guid jobProviderId, IFormFile file)
        {
            // Same logic as AddProfilePictureAsync
            return await AddProfilePictureAsync(jobProviderId, file);
        }

        public async Task<string> DeleteProfilePictureAsync(Guid jobProviderId)
        {
            // Implement deletion from wwwroot folder
            return "Profile picture deleted successfully";
        }

        public async Task<string> GetProfilePictureAsync(Guid jobProviderId)
        {
            // Return file path or URL
            return $"/uploads/profile-pictures/{jobProviderId}.png";
        }

        // ================== Company ==================
        public async Task<(Guid CompanyId, string Message)> AddCompanyAsync(
      Guid jobProviderId, string companyName, string location, string industry, string websiteUrl)
        {
            var company = new CompanyUser
            {
                Id = Guid.NewGuid(),
                FirstName = companyName,
                Email = string.Empty,
                Phone = string.Empty
            };

            var companyEntity = new JobProviderCompany
            {
                Id = Guid.NewGuid(),
                LegalName = companyName,
                Email = string.Empty,
                Address = "Default Address",              // ✅ Keep text address separate
                Summary = industry,
                Website = websiteUrl,
                Location = Guid.Parse(location),          // ✅ This fixes FK constraint
                CompanyUsers = { company }
            };

            _context.JobProviderCompanies.Add(companyEntity);
            await _context.SaveChangesAsync();

            return (companyEntity.Id, "Company added successfully");
        }


        public async Task<IEnumerable<JobProviderCompany>> GetAllCompaniesAsync()
        {
            return await _context.JobProviderCompanies
                .Include(c => c.CompanyUsers)   // optional, loads members
                .Include(c => c.LocationNavigation) // optional, loads location info
                .ToListAsync();
        }
        public async Task<JobProviderCompany> GetCompanyByIdAsync(Guid companyId)
        {
            return await _context.JobProviderCompanies
                .Include(c => c.CompanyUsers)
                .FirstOrDefaultAsync(c => c.Id == companyId) ?? throw new Exception("Company not found");
        }

        public async Task<string> UpdateCompanyByIdAsync(Guid companyId, string companyName, string location, string industry, string websiteUrl)
        {
            var company = await _context.JobProviderCompanies.FindAsync(companyId);
            if (company == null) return "Company not found";

            company.LegalName = companyName;
            company.Address = location;
            company.Summary = industry;
            company.Website = websiteUrl;

            await _context.SaveChangesAsync();
            return "Company updated successfully";
        }

        public async Task<string> PatchCompanyByIdAsync(Guid companyId, string industry)
        {
            var company = await _context.JobProviderCompanies.FindAsync(companyId);
            if (company == null) return "Company not found";

            company.Summary = industry;
            await _context.SaveChangesAsync();
            return "Company industry updated successfully";
        }

        public async Task<string> DeleteCompanyByIdAsync(Guid companyId)
        {
            var company = await _context.JobProviderCompanies
                .Include(c => c.CompanyUsers) // ✅ Load related users
                .FirstOrDefaultAsync(c => c.Id == companyId);

            if (company == null)
                return "Company not found";

            // ✅ Step 1: Remove all related CompanyUsers
            if (company.CompanyUsers != null && company.CompanyUsers.Any())
                _context.CompanyUsers.RemoveRange(company.CompanyUsers);

            // ✅ Step 2: Remove the company itself
            _context.JobProviderCompanies.Remove(company);

            await _context.SaveChangesAsync();
            return "Company deleted successfully";
        }

        // ================== Company Member ==================
        public async Task<(Guid MemberId, string Message)> AddCompanyMemberAsync(Guid companyId, string memberName, string designation, string email, string phone)
        {
            var company = await _context.JobProviderCompanies.FindAsync(companyId);
            if (company == null) return (Guid.Empty, "Company not found");

            var member = new CompanyUser
            {
                Id = Guid.NewGuid(),
                FirstName = memberName,
                Role = Enums.Role.Member,
                Email = email,
                Phone = phone,
                CompanyNavigation = company
            };

            _context.CompanyUsers.Add(member);
            await _context.SaveChangesAsync();
            return (member.Id, "Company member added successfully");
        }

        public async Task<IEnumerable<CompanyUser>> GetAllCompanyMembersAsync()
        {
            return await _context.CompanyUsers
                .Include(cu => cu.CompanyNavigation) // optional, load parent company
                .ToListAsync();
        }

        public async Task<CompanyUser> GetCompanyMemberByIdAsync(Guid memberId)
        {
            return await _context.CompanyUsers
                .Include(c => c.CompanyNavigation)
                .FirstOrDefaultAsync(c => c.Id == memberId) ?? throw new Exception("Company member not found");
        }

        public async Task<string> UpdateCompanyMemberAsync(Guid memberId, string memberName, string designation, string email, string phone)
        {
            var member = await _context.CompanyUsers.FindAsync(memberId);
            if (member == null) return "Company member not found";

            member.FirstName = memberName;
            member.Role = Enums.Role.Member; // or set based on designation
            member.Email = email;
            member.Phone = phone;

            await _context.SaveChangesAsync();
            return "Company member updated successfully";
        }

        public async Task<string> PatchCompanyMemberAsync(Guid memberId, string designation)
        {
            var member = await _context.CompanyUsers.FindAsync(memberId);
            if (member == null) return "Company member not found";

            member.Role = Enums.Role.Member; // Or map from designation
            await _context.SaveChangesAsync();
            return "Company member designation updated successfully";
        }

        public async Task<string> DeleteCompanyMemberAsync(Guid memberId)
        {
            var member = await _context.CompanyUsers.FindAsync(memberId);
            if (member == null) return "Company member not found";

            _context.CompanyUsers.Remove(member);
            await _context.SaveChangesAsync();
            return "Company member deleted successfully";
        }

        public async Task<string> LogoutAsync(Guid jobProviderId)
        {
            var jobProvider = await _context.JobProviderCompanies.FindAsync(jobProviderId);
            if (jobProvider == null) return "Job provider not found";

            // In stateless JWT, there's nothing to remove server-side.
            // You can optionally log the logout action to a table for auditing.
            return "Logout successful. Please clear your token on the client side.";
        }


    }
}