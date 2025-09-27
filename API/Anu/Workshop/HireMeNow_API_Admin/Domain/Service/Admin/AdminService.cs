using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using Domain.Service.Admin.DTOs;
using Domain.Service.Admin.Interfaces;
using Domain.Service.Profile.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;


namespace Domain.Service.Admin
{
    public class AdminService :IAdminService 
    {
        IAdminRepository _adminRepository;
        IMapper _mapper;

        public AdminService(IAdminRepository adminRepository, IMapper mapper)


        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }

        public async Task<List<Domain.Models.JobSeeker>> GetJobSeekers()
        {
            return await _adminRepository.GetJobSeekers();
        }

        public async Task<bool> AddSkillAsync(SkillDto skill)
        {
            var Skill = _mapper.Map<Skill>(skill);
            var result = await _adminRepository.AddAsync(Skill);

            return result;
        }

        public async Task<bool> RemoveSkillAsync(Guid skillId)
        {
            var result = await _adminRepository.RemoveAsync(skillId);

            return result;
        }

        
        public async Task<bool> AddLocationAsync(LocationDto location)
        {
            var Location = _mapper.Map<Location>(location);
            var result = await _adminRepository.addLocationAsync(Location);
            return result;
        }

        public async Task<List<JobProviderCompany>> GetCompanies()
        {
            return await _adminRepository.GetCompanies();
        }

        public Task<List<JobProviderCompany>> SearchCompanies(string name)
        {
            return _adminRepository.SearchCompanies(name);
        }

        public async Task<List<JobPost>> GetJobs()
        {
            return await _adminRepository.GetJobs();
        }

        public async Task<List<JobPost>> GetJobs(string JobLitle)
        {

            var jobs = await _adminRepository.GetJobs(JobLitle);

            return jobs;


        }

        public void DeleteById(Guid id)
        {
            _adminRepository.DeleteById(id);
        }

        public int GetJobProviderCount()
        {
            return _adminRepository.GetJobProviderCount();
        }

        public int GetJobCount()
        {
            return _adminRepository.GetJobCount();
        }

        public async Task<List<Location>> GetLocations()
        {
            return await _adminRepository.GetLocations();
        }


        public void DeleteByLocationId(Guid id)
        {
            _adminRepository.DeleteByLocationId(id);
        }

        public async Task<JobProviderDto> GetProvidercompanyByIdAsync(Guid id)
        {
            var jobProviderCompanyByid = await _adminRepository.GetProvidercompanyByIdAsync(id);
            return _mapper.Map<JobProviderDto>(jobProviderCompanyByid);
        }

        public async Task<CompanyUserDto> UpdatecompanyUserAsync(CompanyUserDto companyuserdto)
        {
            var updatecompanyuser = _mapper.Map<CompanyUser>(companyuserdto);
            updatecompanyuser = await _adminRepository.UpdateCompanyuserAsync(updatecompanyuser);
            return _mapper.Map<CompanyUserDto>(updatecompanyuser);
        }


        public async Task<bool> PatchSkillAsync(SkillDto skilldto)
        {
            var patchskill=_mapper.Map <Skill>(skilldto);
            return await _adminRepository.Patchasync (patchskill);
        }

       

        public async Task<bool> PatchSeekerAsync(JobSeekerDto seekerdto)
        {
            var patchseeker = _mapper.Map<JobSeeker>(seekerdto);
            return await _adminRepository.PatchSeekerasync(patchseeker);
        }


    }
}
