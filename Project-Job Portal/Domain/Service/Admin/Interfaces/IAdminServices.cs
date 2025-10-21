using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.Admin.DTOs;
using Domain.Service.JobProvider.DTOs;
using Domain.Service.Login.DTOs;

namespace Domain.Service.Admin.Interfaces
{
    public interface IAdminServices
    {
        Task<IndustryDto> AddIndustryAsync(IndustryDto request);
        Task<List<IndustryDto>> GetAllIndustriesAsync();
        Task<IndustryDto> GetIndustryByIdAsync(Guid id);

        Task<int> GetIndustryCountAsync();
        Task<IndustryDto?> UpdateIndustryAsync(Guid id, IndustryDto dto);
        Task<Industry?> PatchIndustryAsync(Guid id, IndustryDto updatedData);
        Task<bool> DeleteIndustryAsync(Guid id);



        Task<IEnumerable<JobDto>> GetPendingJobsAsync();
        Task<bool> ApproveJobAsync(Guid jobId);
        Task<bool> RejectJobAsync(Guid jobId);



    }
}
