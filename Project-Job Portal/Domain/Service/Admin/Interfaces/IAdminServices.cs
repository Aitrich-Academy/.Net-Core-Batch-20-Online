using Domain.Models;
using Domain.Service.Admin.DTOs;
using Domain.Service.Profile.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Admin.Interfaces
{
    public interface IAdminServices
    {
        Task<bool> AddSkillAsync(SkillDto skill);

        Task<bool> RemoveSkillAsync(Guid skillId);
        Task<bool> UpdateSkillAsync(Guid skillId, SkillDto skill);
        Task<bool> PatchSkillAsync(Guid skillId, SkillDto skill);
        Task<IEnumerable<SkillDto>> GetAllSkillsAsync();
        Task<bool> AddLocationAsync(LocationDto location);
        Task<SkillDto?> GetSkillByIdAsync(Guid id);
        Task<bool> UpdateLocationAsync(Guid locationId, LocationDto location);
        Task<bool> PatchLocationAsync(Guid locationId, LocationDto location);

        Task<bool> RemoveLocationAsync(Guid locationId);
        Task<IEnumerable<LocationDto>> GetAllLocationsAsync();
        Task<LocationDto?> GetLocationByIdAsync(Guid id);
      






    }
}
