using AutoMapper;
using Domain.Models;
using Domain.Service.Admin.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Admin
{
    public class AdminRepository : IAdminRepository
    {
        //private readonly List<Domain.Models.JobSeeker> _jobSeeker;
        //HireMeNowDbContext _context;
        //IMapper _mapper;

        //public AdminRepository(HireMeNowDbContext context, IMapper mapper)
        //{
        //    _context = context;
        //    _mapper = mapper;
        //}

        public async Task<bool> AddAsync(Skill skill)
        {
            if (skill == null)
                throw new ArgumentNullException(nameof(skill));
            if (_context.Skills.Any(s => s.Name == skill.Name))
            {
                return false; // Skill with the same name already exists
            }
            skill.Id = Guid.NewGuid();
            _context.Skills.Add(skill);
            await _context.SaveChangesAsync();
            return true; // Skill added successfully
        }
        public async Task<bool> UpdateAsync(Guid skillId, Skill updatedSkill)
        {
            var existingSkill = await _context.Skills.FindAsync(skillId);
            if (existingSkill == null) return false;

            // Replace all fields
            existingSkill.Name = updatedSkill.Name;
            existingSkill.Description = updatedSkill.Description;

            _context.Skills.Update(existingSkill);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> PatchAsync(Guid skillId, Skill updatedSkill)
        {
            var existingSkill = await _context.Skills.FindAsync(skillId);
            if (existingSkill == null) return false;

            // Update only provided fields
            if (!string.IsNullOrEmpty(updatedSkill.Name))
                existingSkill.Name = updatedSkill.Name;

            if (!string.IsNullOrEmpty(updatedSkill.Description))
                existingSkill.Description = updatedSkill.Description;

            _context.Skills.Update(existingSkill);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<IEnumerable<Skill>> GetAllSkillsAsync()
        {
            return await _context.Skills.ToListAsync();
        }
        public async Task<Skill?> GetSkillByIdAsync(Guid id)
        {
            return await _context.Skills.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<bool> RemoveAsync(Guid skillId)
        {
            var skillToRemove = await _context.Skills.FindAsync(skillId);

            if (skillToRemove == null)
            {
                return false; // Skill not found
            }

            _context.Skills.Remove(skillToRemove);
            await _context.SaveChangesAsync();

            return true; // Skill removed successfully
        }
        public async Task<bool> AddLocationAsync(Location location)
        {
            if (location == null)
                throw new ArgumentNullException(nameof(location));

            // Check if location with same name already exists
            if (_context.Locations.Any(l => l.Name == location.Name))
                return false;

            location.Id = Guid.NewGuid();
            _context.Locations.Add(location);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Location>> GetAllLocationsAsync()
        {
            return await _context.Locations.ToListAsync();
        }

        public async Task<Location?> GetLocationByIdAsync(Guid id)
        {
            return await _context.Locations.FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task<bool> UpdateLocationAsync(Guid locationId, Location updatedLocation)
        {
            var existingLocation = await _context.Locations.FindAsync(locationId);
            if (existingLocation == null) return false;

            existingLocation.Name = updatedLocation.Name;
            existingLocation.Description = updatedLocation.Description;

            _context.Locations.Update(existingLocation);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> PatchLocationAsync(Guid locationId, Location updatedLocation)
        {
            var existingLocation = await _context.Locations.FindAsync(locationId);
            if (existingLocation == null) return false;

            // Update only provided fields
            if (!string.IsNullOrEmpty(updatedLocation.Name))
                existingLocation.Name = updatedLocation.Name;

            if (!string.IsNullOrEmpty(updatedLocation.Description))
                existingLocation.Description = updatedLocation.Description;

            _context.Locations.Update(existingLocation);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> RemoveLocationAsync(Guid locationId)
        {
            var locationToRemove = await _context.Locations.FindAsync(locationId);
            if (locationToRemove == null) return false;

            _context.Locations.Remove(locationToRemove);
            await _context.SaveChangesAsync();
            return true;
        }
      

    }
}
