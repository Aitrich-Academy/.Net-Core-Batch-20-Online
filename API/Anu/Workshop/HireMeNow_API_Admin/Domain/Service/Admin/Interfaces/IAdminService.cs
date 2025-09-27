using Domain.Models;
using Domain.Service.Admin.DTOs;
using Domain.Service.Profile.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Service.Admin.Interfaces
{
    public interface IAdminService
    {
        public Task<List<Domain.Models.JobSeeker>> GetJobSeekers();
        Task<bool> AddSkillAsync(SkillDto skill);

        Task<bool> RemoveSkillAsync(Guid skillId);

        Task<bool> AddLocationAsync(LocationDto  location);

        public Task<List<JobProviderCompany>> GetCompanies();

        public Task<List<JobProviderCompany>> SearchCompanies(string name);

        public Task<List<JobPost>> GetJobs();

        public Task<List<JobPost>> GetJobs(string JobLitle);

        public void DeleteById(Guid id);

        public int GetJobProviderCount();

        public int GetJobCount();

        public Task<List<Location>> GetLocations();

        public void DeleteByLocationId(Guid id);

        Task<JobProviderDto> GetProvidercompanyByIdAsync(Guid id);

        Task<CompanyUserDto> UpdatecompanyUserAsync(CompanyUserDto companyuserdto);

        Task <bool> PatchSkillAsync(SkillDto   skilldto);

        
        Task<bool> PatchSeekerAsync(JobSeekerDto  seekerdto);


    }
}
