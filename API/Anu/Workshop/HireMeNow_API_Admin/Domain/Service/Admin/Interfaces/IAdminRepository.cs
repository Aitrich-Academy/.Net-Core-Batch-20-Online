using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.Admin.Interfaces
{
    public interface IAdminRepository
    {
        public Task<List<Domain.Models.JobSeeker>> GetJobSeekers();

        Task<bool> AddAsync(Skill skill);

        Task<bool> RemoveAsync(Guid skillId);

        Task<bool> addLocationAsync(Location location);

        public Task<List<JobProviderCompany>> GetCompanies();

        Task<List<JobProviderCompany>> SearchCompanies(string name);

        public Task<List<JobPost>> GetJobs();

        public Task<List<JobPost>> GetJobs(string JobLitle);

        public void DeleteById(Guid id);

        public int GetJobProviderCount();

        public int GetJobCount();

        public Task<List<Location>> GetLocations();

        public void DeleteByLocationId(Guid id);


        Task<JobProviderCompany> GetProvidercompanyByIdAsync(Guid id);


        Task<CompanyUser> UpdateCompanyuserAsync(CompanyUser companyuser);

        Task<bool> Patchasync(Skill partialskill);

        

        Task<bool> PatchSeekerasync(JobSeeker PartialSeekerupdate);

    }
}
