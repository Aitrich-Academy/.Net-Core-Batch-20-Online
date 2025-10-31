using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Admin.Interfaces
{
    public interface IAdminRepository
    {
        void AddIndustry(Industry industry);
        Task<List<Industry>> GetAllIndustriesAsync();
        Task<Industry?> GetIndustryByIdAsync(Guid id);
        Task<int> GetIndustryCountAsync();
        Task<Industry> UpdateIndustryAsync(Industry industry);
        //Task<Industry?> PatchIndustryAsync(Guid id, Industry industry);
        Task<bool> PatchIndustryAsync( Industry industry);
        Task<bool> DeleteIndustryAsync(Guid id);


        Task<IEnumerable<JobPost>> GetPendingJobsAsync();
        Task<bool> ApproveJobAsync(Guid jobId);
        Task<bool> RejectJobAsync(Guid jobId);

        Task<JobCategory> AddJobCategoryAsync(JobCategory category);
        Task<IEnumerable<JobCategory>> GetAllJobCategoryAsync();
        Task<JobCategory?> GetJobCategoryByIdAsync(Guid id);
        Task<bool> UpdateJobCategoryAsync(JobCategory category);
        Task<bool> PatchJobCategoryAsync( JobCategory dto);
        Task<bool> DeleteJobCategoryAsync(Guid id);

        Task<int> GetJobCountAsync();
        Task<JobPost?> GetJobByNameAsync(string jobTitle);

        Task<IEnumerable<JobProviderCompany>> GetAllProviders();
        Task<JobProviderCompany?> GetJobProviderByIdAsync(Guid id);
        Task<int> GetJobProviderCountAsync();

        Task<bool> DeleteJobProviderAsync(Guid id);


    }
}
