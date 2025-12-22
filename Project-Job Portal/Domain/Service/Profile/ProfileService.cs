using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using Domain.Service.JobSeeker;
using Domain.Service.Profile.DTOs;
using Domain.Service.Profile.Interface;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Service.Profile
{
    public class ProfileService : IJobSeekerProfileService
    {
        public readonly IJobSeekerProfileRepository _profileRepository;
        private readonly HireMeNowDbContext _context;
        IMapper mapper;
        public ProfileService(IJobSeekerProfileRepository profileRepository, IMapper _mapper, HireMeNowDbContext context)
        {
            mapper = _mapper;
            _profileRepository = profileRepository;
            _context = context;
        }


        public async Task<JobSeekerProfileDto> CreateProfileAsync(JobSeekerProfileDto dto, Guid jobSeekerId)
        {
            var jobSeeker = await _context.JobSeekers.FindAsync(jobSeekerId);
            if (jobSeeker == null)
                throw new InvalidOperationException("JobSeeker does not exist.");

            string? imagePath = null, resumePath = null;

            // Define root paths
            var wwwRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

            // ✅ Save image file
            if (dto.SeekerImage != null && dto.SeekerImage.Length > 0)
            {
                var imageFolder = Path.Combine(wwwRootPath, "Images");
                Directory.CreateDirectory(imageFolder);

                var imageFileName = $"{Guid.NewGuid()}{Path.GetExtension(dto.SeekerImage.FileName)}";
                var imageFullPath = Path.Combine(imageFolder, imageFileName);

                using (var stream = new FileStream(imageFullPath, FileMode.Create))
                {
                    await dto.SeekerImage.CopyToAsync(stream);
                }

                imagePath = $"/Images/{imageFileName}"; // relative URL
            }

            // ✅ Save resume file
            if (dto.Resume != null && dto.Resume.Length > 0)
            {
                var resumeFolder = Path.Combine(wwwRootPath, "Resumes");
                Directory.CreateDirectory(resumeFolder);

                var resumeFileName = $"{Guid.NewGuid()}{Path.GetExtension(dto.Resume.FileName)}";
                var resumeFullPath = Path.Combine(resumeFolder, resumeFileName);

                using (var stream = new FileStream(resumeFullPath, FileMode.Create))
                {
                    await dto.Resume.CopyToAsync(stream);
                }

                resumePath = $"/Resumes/{resumeFileName}";
            }

            var profile = new JobSeekerProfile
            {
                Id = Guid.NewGuid(),
                JobSeekerId = jobSeekerId,
                ProfileName = dto.ProfileName,
                ProfileSummary = dto.ProfileSummary,
                SeekerImage = imagePath,
                Resume = resumePath
            };

            await _profileRepository.CreateJobseekerProfileAsync(profile);

            return new JobSeekerProfileDto
            {
                Id = profile.Id,
                JobSeekerId = profile.JobSeekerId,
                ProfileName = profile.ProfileName,
                ProfileSummary = profile.ProfileSummary,
                ImagePath = profile.SeekerImage,
                ResumePath = profile.Resume
            };
        }



        public async Task<JobSeekerProfileDto> UpdateProfileAsync(JobSeekerProfileDto dto, Guid jobSeekerId)
        {
            var profile = await _profileRepository.GetByJobSeekerIdAsync(jobSeekerId);
            if (profile == null)
                throw new Exception("Profile not found for this Job Seeker.");

            // ✅ Update text fields
            if (!string.IsNullOrEmpty(dto.ProfileName))
                profile.ProfileName = dto.ProfileName;

            if (!string.IsNullOrEmpty(dto.ProfileSummary))
                profile.ProfileSummary = dto.ProfileSummary;

            // ✅ Define root path
            var wwwRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

            // ✅ Update image if new file is uploaded
            if (dto.SeekerImage != null && dto.SeekerImage.Length > 0)
            {
                var imageFolder = Path.Combine(wwwRootPath, "Images");
                Directory.CreateDirectory(imageFolder);

                // 🔹 Delete old image if exists
                if (!string.IsNullOrEmpty(profile.SeekerImage))
                {
                    var oldImagePath = Path.Combine(wwwRootPath, profile.SeekerImage.TrimStart('/'));
                    if (File.Exists(oldImagePath))
                        File.Delete(oldImagePath);
                }

                // 🔹 Save new image
                var newImageFileName = $"{Guid.NewGuid()}{Path.GetExtension(dto.SeekerImage.FileName)}";
                var newImageFullPath = Path.Combine(imageFolder, newImageFileName);

                using (var stream = new FileStream(newImageFullPath, FileMode.Create))
                {
                    await dto.SeekerImage.CopyToAsync(stream);
                }

                profile.SeekerImage = $"/Images/{newImageFileName}";
            }

            // ✅ Update resume if new file is uploaded
            if (dto.Resume != null && dto.Resume.Length > 0)
            {
                var resumeFolder = Path.Combine(wwwRootPath, "Resumes");
                Directory.CreateDirectory(resumeFolder);

                // 🔹 Delete old resume if exists
                if (!string.IsNullOrEmpty(profile.Resume))
                {
                    var oldResumePath = Path.Combine(wwwRootPath, profile.Resume.TrimStart('/'));
                    if (File.Exists(oldResumePath))
                        File.Delete(oldResumePath);
                }

                // 🔹 Save new resume
                var newResumeFileName = $"{Guid.NewGuid()}{Path.GetExtension(dto.Resume.FileName)}";
                var newResumeFullPath = Path.Combine(resumeFolder, newResumeFileName);

                using (var stream = new FileStream(newResumeFullPath, FileMode.Create))
                {
                    await dto.Resume.CopyToAsync(stream);
                }

                profile.Resume = $"/Resumes/{newResumeFileName}";
            }

            // ✅ Save changes
            var updated = await _profileRepository.UpdateJobseekerProfileAsync(profile);

            // ✅ Return DTO
            return new JobSeekerProfileDto
            {
                Id = updated.Id,
                JobSeekerId = updated.JobSeekerId,
                ProfileName = updated.ProfileName,
                ProfileSummary = updated.ProfileSummary,
                ImagePath = updated.SeekerImage,
                ResumePath = updated.Resume
            };
        }

        public async Task<JobSeekerProfileDto?> PatchProfileAsync(JobSeekerProfileDto dto, Guid jobSeekerId)
        {
            var profile = await _profileRepository.GetByJobSeekerIdAsync(jobSeekerId);
            if (profile == null)
                return null;

            // ✅ Update text fields only if provided
            if (!string.IsNullOrEmpty(dto.ProfileName))
                profile.ProfileName = dto.ProfileName;

            if (!string.IsNullOrEmpty(dto.ProfileSummary))
                profile.ProfileSummary = dto.ProfileSummary;

            // ✅ Define wwwroot path
            var wwwRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");

            // ✅ Handle image update (optional)
            if (dto.SeekerImage != null && dto.SeekerImage.Length > 0)
            {
                var imageFolder = Path.Combine(wwwRootPath, "Images");
                Directory.CreateDirectory(imageFolder);

                // Delete old image if exists
                if (!string.IsNullOrEmpty(profile.SeekerImage))
                {
                    var oldImagePath = Path.Combine(wwwRootPath, profile.SeekerImage.TrimStart('/'));
                    if (File.Exists(oldImagePath))
                        File.Delete(oldImagePath);
                }

                // Save new image
                var imageFileName = $"{Guid.NewGuid()}{Path.GetExtension(dto.SeekerImage.FileName)}";
                var imageFullPath = Path.Combine(imageFolder, imageFileName);

                using (var stream = new FileStream(imageFullPath, FileMode.Create))
                {
                    await dto.SeekerImage.CopyToAsync(stream);
                }

                profile.SeekerImage = $"/Images/{imageFileName}";
            }

            // ✅ Handle resume update (optional)
            if (dto.Resume != null && dto.Resume.Length > 0)
            {
                var resumeFolder = Path.Combine(wwwRootPath, "Resumes");
                Directory.CreateDirectory(resumeFolder);

                // Delete old resume if exists
                if (!string.IsNullOrEmpty(profile.Resume))
                {
                    var oldResumePath = Path.Combine(wwwRootPath, profile.Resume.TrimStart('/'));
                    if (File.Exists(oldResumePath))
                        File.Delete(oldResumePath);
                }

                // Save new resume
                var resumeFileName = $"{Guid.NewGuid()}{Path.GetExtension(dto.Resume.FileName)}";
                var resumeFullPath = Path.Combine(resumeFolder, resumeFileName);

                using (var stream = new FileStream(resumeFullPath, FileMode.Create))
                {
                    await dto.Resume.CopyToAsync(stream);
                }

                profile.Resume = $"/Resumes/{resumeFileName}";
            }

            // ✅ Save updates
            var updated = await _profileRepository.UpdateJobseekerProfileAsync(profile);

            // ✅ Return updated DTO
            return new JobSeekerProfileDto
            {
                Id = updated.Id,
                JobSeekerId = updated.JobSeekerId,
                ProfileName = updated.ProfileName,
                ProfileSummary = updated.ProfileSummary,
                ImagePath = updated.SeekerImage,
                ResumePath = updated.Resume
            };
        }





        public async Task<JobSeekerProfileViewDto?> GetProfileByJobSeekerIdAsync(Guid jobSeekerId)
        {
            var profile = await _profileRepository.GetByJobSeekerIdAsync(jobSeekerId);

            if (profile == null)
                return null;

            return new JobSeekerProfileViewDto
            {
                Id = profile.Id,
                JobSeekerId = profile.JobSeekerId,
                ProfileName = profile.ProfileName,
                ProfileSummary = profile.ProfileSummary,
                // ✅ Already Base64 strings, so no conversion needed
                ImageBase64 = profile.SeekerImage,
                ResumeBase64 = profile.Resume
            };
        }


        public async Task<string> DeleteProfileAsync(Guid jobSeekerId)
        {

            var hasApplied = await _profileRepository.HasAppliedJobsAsync(jobSeekerId);
            if (hasApplied)
                return "Cannot delete profile. JobSeeker has applied for one or more jobs.";


            var deleted = await _profileRepository.DeleteProfileAsync(jobSeekerId);
            if (!deleted)
                return "Profile not found.";

            return "Profile deleted successfully.";
        }

        public async Task<string?> GetResumeByJobSeekerIdAsync(Guid jobSeekerId)
        {
            return await _profileRepository.GetResumeByJobSeekerIdAsync(jobSeekerId);
        }




        public async Task<List<Skill>> GetAllSkillsAsync()
        {
            return await _profileRepository.GetAllSkillsAsync();
        }

        public async Task<string> AddSkillsToJobSeekerAsync(Guid jobSeekerId, List<Guid> skillIds)
        {
            var success = await _profileRepository.AddSkillsToJobSeekerAsync(jobSeekerId, skillIds);
            return success ? "Skills added successfully." : "JobSeeker profile not found.";
        }


        public async Task<bool> UpdateSkillsAsync(Guid jobSeekerId, List<Guid> newSkillIds)
        {
            return await _profileRepository.UpdateSkillsAsync(jobSeekerId, newSkillIds);
        }


        public async Task<bool> PatchSkillsAsync(Guid jobSeekerId, List<Guid> addSkillIds, List<Guid> removeSkillIds)
        {
            return await _profileRepository.PatchSkillsAsync(jobSeekerId, addSkillIds, removeSkillIds);
        }

        public async Task<bool> DeleteSkillsAsync(Guid jobSeekerId, List<Guid> skillIds)
        {
            return await _profileRepository.DeleteSkillsAsync(jobSeekerId, skillIds);
        }

        public async Task<List<SkillDto>> GetSkillsByJobSeekerIdAsync(Guid jobSeekerId)
        {
            var skills = await _profileRepository.GetSkillsByJobSeekerIdAsync(jobSeekerId);
            return mapper.Map<List<SkillDto>>(skills);
        }

        public async Task<WorkExperienceDto> AddWorkExperienceAsync(Guid jobSeekerId, WorkExperienceDto dto)
        {

            //var profile = await _context.JobSeekerProfiles
            //    .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);

            var profile = await _context.JobSeekerProfiles
    .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId && p.ProfileName != null);


            if (profile == null)
                throw new Exception("JobSeeker profile not found");

            var entity = mapper.Map<WorkExperience>(dto);
            entity.Id = Guid.NewGuid();
            entity.JobSeekerProfileId = profile.Id;
            

            await _profileRepository.AddWorkExperiencesync(entity);
            await _profileRepository.SaveChangesAsync();
            Console.WriteLine("JobSeekerId param: " + jobSeekerId);
            Console.WriteLine("Profile.Id: " + profile.Id);
            Console.WriteLine("Assigned JobSeekerProfileId: " + entity.JobSeekerProfileId);

            return mapper.Map<WorkExperienceDto>(entity);
            



        }

        //public async Task AddWorkExperienceAsync(Guid userId, WorkExperienceDto request)
        //{
        //    // 1️⃣ Find the user's profile
        //    var profile = await _context.JobSeekerProfiles
        //                                .FirstOrDefaultAsync(p => p.JobSeekerId == userId);

        //    if (profile == null)
        //        throw new Exception("User profile not found. Create a profile first.");

        //    // 2️⃣ Create WorkExperience entity
        //    var work = new WorkExperience
        //    {
        //        JobSeekerProfileId = profile.Id, // FK points to existing profile
        //        JobTitle = request.JobTitle,
        //        CompanyName = request.CompanyName,
        //        Summary = request.Summary,
        //        ServiceStart = request.ServiceStart,
        //        ServiceEnd = request.ServiceEnd
        //    };

        //    // 3️⃣ Add and save
        //    _context.WorkExperiences.Add(work);
        //    await _context.SaveChangesAsync();

        //}

        //public async Task<WorkExperienceDto> AddWorkExperienceAsync(WorkExperienceDto workExperienceDto)
        //{
        //    var entity = mapper.Map<WorkExperience>(workExperienceDto);
        //    await _profileRepository.AddAsync(entity);
        //    await _profileRepository.SaveChangesAsync();

        //    return mapper.Map<WorkExperienceDto>(entity);
        //}



        public async Task<WorkExperienceDto> UpdateWorkExperienceAsync(Guid jobSeekerId, WorkExperienceDto dto)
        {
            var profile = await _context.JobSeekerProfiles
                .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);

            if (profile == null)
                throw new Exception("JobSeeker profile not found");

            var existing = await _profileRepository.GetWorkExperienceByIdAsync(dto.Id);

            if (existing == null)
                throw new Exception("Work experience not found");


            if (existing.JobSeekerProfileId != profile.Id)
                throw new UnauthorizedAccessException("You can update only your own experiences.");


            existing.JobTitle = dto.JobTitle;
            existing.CompanyName = dto.CompanyName;
            existing.Summary = dto.Summary;
            existing.ServiceStart = dto.ServiceStart;
            existing.ServiceEnd = dto.ServiceEnd;

            await _profileRepository.UpdateWorkExperienceAsync(existing);

            return mapper.Map<WorkExperienceDto>(existing);
        }


        public async Task<WorkExperienceDto> PatchWorkExperienceAsync(Guid jobSeekerId, WorkExperienceDto dto)
        {
            var profile = await _context.JobSeekerProfiles
                .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);

            if (profile == null)
                throw new Exception("JobSeeker profile not found.");

            var existing = await _profileRepository.GetWorkExperienceByIdAsync(dto.Id);

            if (existing == null)
                throw new Exception("Work experience not found.");

            if (existing.JobSeekerProfileId != profile.Id)
                throw new UnauthorizedAccessException("You can only modify your own work experiences.");


            if (!string.IsNullOrEmpty(dto.JobTitle)) existing.JobTitle = dto.JobTitle;
            if (!string.IsNullOrEmpty(dto.CompanyName)) existing.CompanyName = dto.CompanyName;
            if (!string.IsNullOrEmpty(dto.Summary)) existing.Summary = dto.Summary;
            if (dto.ServiceStart != default) existing.ServiceStart = dto.ServiceStart;
            if (dto.ServiceEnd != default) existing.ServiceEnd = dto.ServiceEnd;

            await _profileRepository.UpdateWorkExperienceAsync(existing);

            return mapper.Map<WorkExperienceDto>(existing);
        }

        public async Task<List<WorkExperienceDto>> GetWorkExperienceByJobSeekerIdAsync(Guid jobSeekerId)
        {
            var experiences = await _profileRepository.GetBySeekerIdAsync(jobSeekerId);

            if (experiences == null || !experiences.Any())
                return new List<WorkExperienceDto>();

            return mapper.Map<List<WorkExperienceDto>>(experiences);
        }

        public async Task<bool> DeleteWorkExperienceAsync(Guid workExperienceId, Guid jobSeekerId)
        {
            var existing = await _profileRepository.GetBySeekerWorkExperienceIdAsync(workExperienceId);

            if (existing == null)
                throw new KeyNotFoundException("Work experience not found.");


            if (existing.JobSeekerProfile.JobSeekerId != jobSeekerId)
                throw new UnauthorizedAccessException("You cannot delete another user's record.");

            return await _profileRepository.DeleteWorkExperienceAsync(existing);
        }


        public async Task<QualificationDto> AddQualificationAsync(Guid jobSeekerId, QualificationDto qualificationDto)
        {


            var profile = await _context.JobSeekerProfiles.FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);
            if (profile == null)
                throw new Exception("Job seeker profile not found.");

            var entity = mapper.Map<Qualification>(qualificationDto);
            entity.JobseekerProfileId = profile.Id;
            entity.JobPostId = null;

            var added = await _profileRepository.AddQualificationAsync(entity);
            return mapper.Map<QualificationDto>(added);
        }



        public async Task<QualificationDto?> UpdateQualificationAsync(Guid qualificationId, Guid jobSeekerId, QualificationDto dto)
        {
            var existing = await _profileRepository.GetQualificationByIdAsync(qualificationId);
            if (existing == null)
                throw new KeyNotFoundException("Qualification not found.");


            var profile = await _context.JobSeekerProfiles.FirstOrDefaultAsync(p => p.Id == existing.JobseekerProfileId);
            if (profile == null || profile.JobSeekerId != jobSeekerId)
                throw new UnauthorizedAccessException("You cannot edit another user's qualification.");


            existing.Name = dto.Name;
            existing.Description = dto.Description;
            existing.JobPostId = null;

            await _profileRepository.UpdateQualificationAsync(existing);

            return mapper.Map<QualificationDto>(existing);
        }


        public async Task<QualificationDto?> PatchQualificationAsync(Guid qualificationId, Guid jobSeekerId, QualificationDto dto)
        {
            var existing = await _profileRepository.GetQualificationByIdAsync(qualificationId);
            if (existing == null)
                throw new KeyNotFoundException("Qualification not found.");


            var profile = await _context.JobSeekerProfiles
                .FirstOrDefaultAsync(p => p.Id == existing.JobseekerProfileId);
            if (profile == null || profile.JobSeekerId != jobSeekerId)
                throw new UnauthorizedAccessException("You cannot edit another user's qualification.");


            if (!string.IsNullOrEmpty(dto.Name))
                existing.Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.Description))
                existing.Description = dto.Description;


            existing.JobPostId = null;

            await _profileRepository.UpdateQualificationAsync(existing);

            return mapper.Map<QualificationDto>(existing);
        }

        public async Task<IEnumerable<QualificationDto>> GetQualificationsByJobSeekerIdAsync(Guid jobSeekerId)
        {
            var qualifications = await _profileRepository.GetQualificationsByJobSeekerIdAsync(jobSeekerId);
            return mapper.Map<IEnumerable<QualificationDto>>(qualifications);
        }

        public async Task<bool> DeleteQualificationAsync(Guid qualificationId, Guid jobSeekerId)
        {
            var qualification = await _profileRepository.GetQualificationDeleteByIdAsync(qualificationId);
            if (qualification == null)
                throw new KeyNotFoundException("Qualification not found.");


            if (qualification.JobSeekerProfile.JobSeekerId != jobSeekerId)
                throw new UnauthorizedAccessException("You are not allowed to delete this qualification.");

            return await _profileRepository.DeleteQualificationAsync(qualification);
        }

    }
}

