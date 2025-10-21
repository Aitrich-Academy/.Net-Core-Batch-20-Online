using AutoMapper;
using Domain.Models;
using Domain.Service.Admin.DTOs;
using Domain.Service.Admin.Interfaces;
using Domain.Service.Profile.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Admin
{
    public  class AdminService : IAdminServices
    {
        //IAdminRepository _adminRepository;
        //IMapper _mapper;

        //public AdminService(IAdminRepository adminRepository, IMapper mapper)


        //{
        //    _adminRepository = adminRepository;
        //    _mapper = mapper;
        //}
        public async Task<bool> AddSkillAsync(SkillDto skill)
        {
            var Skill = _mapper.Map<Skill>(skill);
            var result = await _adminRepository.AddAsync(Skill);

            return result;
        }
        public async Task<bool> UpdateSkillAsync(Guid skillId, SkillDto skill)
        {
            var updatedSkill = _mapper.Map<Skill>(skill);
            return await _adminRepository.UpdateAsync(skillId, updatedSkill);
        }

        public async Task<bool> PatchSkillAsync(Guid skillId, SkillDto skill)
        {
            var updatedSkill = _mapper.Map<Skill>(skill);
            return await _adminRepository.PatchAsync(skillId, updatedSkill);
        }
        public async Task<IEnumerable<SkillDto>> GetAllSkillsAsync()
        {
            var skills = await _adminRepository.GetAllSkillsAsync();
            return _mapper.Map<IEnumerable<SkillDto>>(skills);
        }
        public async Task<SkillDto?> GetSkillByIdAsync(Guid id)
        {
            var skill = await _adminRepository.GetSkillByIdAsync(id);
            return _mapper.Map<SkillDto>(skill);
        }



        public async Task<bool> RemoveSkillAsync(Guid skillId)
        {
            var result = await _adminRepository.RemoveAsync(skillId);

            return result;
        }
        public async Task<bool> AddLocationAsync(LocationDto location)
        {
            var locationEntity = _mapper.Map<Location>(location);
            var result = await _adminRepository.AddLocationAsync(locationEntity);
            return result;
        }

        public async Task<IEnumerable<LocationDto>> GetAllLocationsAsync()
        {
            var locations = await _adminRepository.GetAllLocationsAsync();
            return _mapper.Map<IEnumerable<LocationDto>>(locations);
        }

        public async Task<LocationDto?> GetLocationByIdAsync(Guid id)
        {
            var location = await _adminRepository.GetLocationByIdAsync(id);
            return _mapper.Map<LocationDto?>(location);
        }

        public async Task<bool> UpdateLocationAsync(Guid locationId, LocationDto location)
        {
            var updatedLocation = _mapper.Map<Location>(location);
            return await _adminRepository.UpdateLocationAsync(locationId, updatedLocation);
        }

        public async Task<bool> PatchLocationAsync(Guid locationId, LocationDto location)
        {
            var updatedLocation = _mapper.Map<Location>(location);
            return await _adminRepository.PatchLocationAsync(locationId, updatedLocation);
        }

        public async Task<bool> RemoveLocationAsync(Guid locationId)
        {
            return await _adminRepository.RemoveLocationAsync(locationId);
        }
     

    }
}
