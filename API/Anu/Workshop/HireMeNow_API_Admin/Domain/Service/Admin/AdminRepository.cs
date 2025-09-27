using AutoMapper;
 
using Domain.Models;
using Domain.Service.Admin.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Extension;

namespace Domain.Service.Admin
{
    public class AdminRepository : IAdminRepository     
    {
        private readonly List<Domain.Models.JobSeeker> _jobSeeker;
        DbHireMeNowWebApiContext _context;
        IMapper _mapper;

        public AdminRepository(DbHireMeNowWebApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Domain.Models.JobSeeker>> GetJobSeekers()
        {
            return await _context.JobSeekers.ToListAsync();
        }

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

        public async Task<bool> addLocationAsync(Location location)
        {
            location.Id = Guid.NewGuid();
            await _context.Locations.AddAsync(location);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<JobProviderCompany>> GetCompanies()
        {
            return await _context.JobProviderCompanies.ToListAsync();
        }

        public async Task<List<JobProviderCompany>> SearchCompanies(string name)

        {
            var filteredCompanies = await _context.JobProviderCompanies
           .Where(company => company.LegalName.Contains(name))
           .ToListAsync();

            return filteredCompanies;
        }

        public async Task<List<JobPost>> GetJobs()
        {

            
            return await _context.JobPosts
                    .Include(j => j.Location)
                    .Include(j => j.Industry)
                    .Include(j => j.JobCategory)
                    .Include(j => j.PostedByNavigation)
                    .ToListAsync();
        }

        public async Task<List<JobPost>> GetJobs(string JobLitle)
        {
            return _context.JobPosts.Where(e => e.JobTitle.Contains(JobLitle)).ToList();

        }

        public void DeleteById(Guid id)
        {
            var item = _context.CompanyUsers.Where(e => e.Id == id).FirstOrDefault();
            if (item != null)
            {
                _context.CompanyUsers.Remove(item);
                _context.SaveChanges();
            }
        }

        public int GetJobProviderCount()
        {
            int count = _context.CompanyUsers.Count();
            return count;
        }


        public int GetJobCount()
        {
            int count = _context.JobPosts.Count();
            return count;
        }

        public async Task<List<Location>> GetLocations()
        {
            return await _context.Locations.ToListAsync();
        }

        public void DeleteByLocationId(Guid id)
        {
            var item = _context.Locations.Where(e => e.Id == id).FirstOrDefault();
            if (item != null)
            {
                _context.Locations.Remove(item);
                _context.SaveChanges();
            }
        }

        public async Task<JobProviderCompany> GetProvidercompanyByIdAsync(Guid id)
        {
            return await _context.JobProviderCompanies.FindAsync(id);
        }

        public async Task<CompanyUser> UpdateCompanyuserAsync(CompanyUser companyuser)
        { 
            _context.CompanyUsers.Update(companyuser);
            await _context.SaveChangesAsync();
            return companyuser;
        }

       public async Task<bool> Patchasync(Skill partialskill)
        {

            var existingskill = await _context.Skills .FirstOrDefaultAsync(x=>x.Id== partialskill.Id);
            if (existingskill == null)  
                return false;
            
             if (!string.IsNullOrWhiteSpace(partialskill.Name))
                existingskill.Name  = partialskill.Name ;

            if (!string.IsNullOrWhiteSpace(partialskill.Description ))
                existingskill.Description  = partialskill.Description;

          

             _context.Skills .Update(existingskill);
            await _context .SaveChangesAsync();
            return true;

        }


        
        public async Task<bool> PatchSeekerasync(JobSeeker PartialSeekerupdate)

        {

            var existingseeker = await _context.JobSeekers.FirstOrDefaultAsync(x => x.Id == PartialSeekerupdate.Id);
            if (existingseeker == null)
                return false;

            if (!string.IsNullOrWhiteSpace(PartialSeekerupdate.UserName))
                existingseeker.UserName = PartialSeekerupdate.UserName ;


            if (!string.IsNullOrWhiteSpace(PartialSeekerupdate.FirstName))
                existingseeker.FirstName = PartialSeekerupdate.FirstName;

            if (!string.IsNullOrWhiteSpace(PartialSeekerupdate.LastName))
                existingseeker.LastName = PartialSeekerupdate.LastName;

            if (!string.IsNullOrWhiteSpace(PartialSeekerupdate.Phone))
                existingseeker.Phone = PartialSeekerupdate.Phone;

            if (!string.IsNullOrWhiteSpace(PartialSeekerupdate.Email))
                existingseeker.Email = PartialSeekerupdate.Email;

            _context.JobSeekers.Update(existingseeker);
            await _context.SaveChangesAsync();
            return true;

        }
    }
}
 