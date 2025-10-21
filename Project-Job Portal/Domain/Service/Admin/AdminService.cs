using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Service.Admin.DTOs;
using Domain.Service.Admin.Interfaces;
using Domain.Service.Authuser;
using Domain.Service.JobProvider.DTOs;
using Domain.Service.Login.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Domain.Service.Admin
{
    public class AdminService : IAdminServices
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IMapper _mapper;
        public AdminService(IAdminRepository adminRepository, IMapper mapper)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;

        }
        //Add Industry
        public async Task<IndustryDto> AddIndustryAsync(IndustryDto request)
        {
            // Map Domain DTO → Entity
            var industry = _mapper.Map<Industry>(request);
            industry.Id = Guid.NewGuid(); // assign new Id

            _adminRepository.AddIndustry(industry);


            // Map Entity → Domain DTO
            return _mapper.Map<IndustryDto>(industry);
        }


        //Get Industry
        public async Task<List<IndustryDto>> GetAllIndustriesAsync()
        {
            var industries = await _adminRepository.GetAllIndustriesAsync();
            return _mapper.Map<List<IndustryDto>>(industries);
        }

        //Get IndustryById
        public async Task<IndustryDto> GetIndustryByIdAsync(Guid id)
        {
            var industry = await _adminRepository.GetIndustryByIdAsync(id);

            if (industry == null)
                return null;

            return _mapper.Map<IndustryDto>(industry);
        }

        //Get industryCount
        public async Task<int> GetIndustryCountAsync()
        {
            return await _adminRepository.GetIndustryCountAsync();
        }

        //Edit Industry
        public async Task<IndustryDto?> UpdateIndustryAsync(Guid id, IndustryDto dto)
        {
            var existing = await _adminRepository.GetIndustryByIdAsync(id);
            if (existing == null)
                return null;

            // Update fields
            existing.Name = dto.Name;
            existing.Description = dto.Description;

            var updated = await _adminRepository.UpdateIndustryAsync(existing);
            return _mapper.Map<IndustryDto>(updated);
        }

        //patch industry
        public async Task<Industry?> PatchIndustryAsync(Guid id, IndustryDto updatedData)
        {
            var mappedPatch = _mapper.Map<Industry>(updatedData);
            return await _adminRepository.PatchIndustryAsync(id, mappedPatch);
        }

        //Delete Industry
        public async Task<bool> DeleteIndustryAsync(Guid id)
        {
            return await _adminRepository.DeleteIndustryAsync(id);
        }




        public async Task<IEnumerable<JobDto>> GetPendingJobsAsync()
        {
            var jobs = await _adminRepository.GetPendingJobsAsync();
            return _mapper.Map<IEnumerable<JobDto>>(jobs);
        }

        public async Task<bool> ApproveJobAsync(Guid jobId)
        {
            return await _adminRepository.ApproveJobAsync(jobId);
        }

        public async Task<bool> RejectJobAsync(Guid jobId)
        {
            return await _adminRepository.RejectJobAsync(jobId);
        }


    }
}
