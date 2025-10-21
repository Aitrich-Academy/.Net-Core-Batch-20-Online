using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Admin.Interfaces
{
    public interface IAdminRepository
    {
        Task<bool> AddAsync(Skill skill);

        Task<bool> RemoveAsync(Guid skillId);
        Task<bool> UpdateAsync(Guid skillId, Skill updatedSkill);
        Task<bool> PatchAsync(Guid skillId, Skill updatedSkill);
        Task<IEnumerable<Skill>> GetAllSkillsAsync();
        Task<bool> AddLocationAsync(Location location);
        Task<Skill?> GetSkillByIdAsync(Guid id);
        Task<bool> UpdateLocationAsync(Guid locationId, Location updatedLocation);
        Task<bool> PatchLocationAsync(Guid locationId, Location updatedLocation);

        Task<bool> RemoveLocationAsync(Guid locationId);
        Task<IEnumerable<Location>> GetAllLocationsAsync();
        Task<Location?> GetLocationByIdAsync(Guid id);
       


    }
}
