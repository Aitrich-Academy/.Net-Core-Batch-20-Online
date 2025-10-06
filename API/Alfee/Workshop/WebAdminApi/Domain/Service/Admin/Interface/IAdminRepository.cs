using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.Admin.Interface
{
    public interface IAdminRepository
    {
        public Task<List<Domain.Models.JobSeeker>> GetJobSeekers();

        Task<bool> AddAsync(Skill skill);

        Task<bool> RemoveAsync(Guid skillId);

        public Task<List<JobProviderCompany>> GetCompanies();

        Task<List<JobProviderCompany>> SearchCompanies(string name);

        public Task<List<JobPost>> GetJobs(string JobLitle);

        public Task<List<JobPost>> GetJobs();

        public void DeleteById(Guid id);

        public int GetJobProviderCount();

        public int GetJobCount();

        Task<Location> addLocation(Location location);

        public Task<List<Location>> GetLocations();

        public void DeleteByLocationId(Guid id);
    }
}
