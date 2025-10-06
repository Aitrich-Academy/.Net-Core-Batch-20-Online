using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.Profile.Dto;

namespace Domain.Service.Profile.Interface
{
    public interface IProfileService
    {
        Task<JobProviderProfileDto?> GetProfileAsync(Guid userId);
        Task<JobProviderProfileDto?> UpdateProfileAsync(JobProviderProfileDto dto);
    }
}
