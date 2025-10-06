using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Service.Profile.Dto;

namespace Domain.Service.Admin.Interface
{
    public interface IAdminService
    {
        public Task<List<Domain.Models.JobSeeker>> GetJobSeekers();

        Task<bool> AddSkillAsync(SkillDto skill);

        Task<bool> RemoveSkillAsync(Guid skillId);

        public Task<List<JobProviderCompany>> GetCompanies();

        public Task<List<JobProviderCompany>> SearchCompanies(string name);

        public Task<List<JobPost>> GetJobs(string JobLitle);

        public Task<List<JobPost>> GetJobs();

        public void DeleteById(Guid id);

        public int GetJobProviderCount();

        public int GetJobCount();

        Task<Location> AddLocation(Location location);

        public Task<List<Location>> GetLocations();

        public void DeleteByLocationId(Guid id);
    }
}
