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
        Task<Industry?> PatchIndustryAsync(Guid id, Industry industry);
        Task<bool> DeleteIndustryAsync(Guid id);


        Task<IEnumerable<JobPost>> GetPendingJobsAsync();
        Task<bool> ApproveJobAsync(Guid jobId);
        Task<bool> RejectJobAsync(Guid jobId);


    }
}
