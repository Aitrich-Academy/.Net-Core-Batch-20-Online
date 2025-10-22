using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
//<<<<<<< HEAD
using Domain.Enums;
using Azure.Core;
using Domain.Mail;
using Domain.Models;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.JobProvider;
using Domain.Service.JobSeeker.DTOs;
using Domain.Service.JobSeeker.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Domain.Service.JobSeeker
{
    public class JobSeekerService : IJobSeekerService
    {
        IJobSeekerRepository jobSeekerRepository;
        //IJobProviderService jobProviderService;
        IAuthUserRepository authUserRepository;
        IMapper mapper;
        IEmailService emailService;
        //private readonly IJobSeekerProfileRepository _repository;
        private readonly HireMeNowDbContext _context;
        public JobSeekerService(IJobSeekerRepository _jobSeekerRepository, IMapper _mapper, IEmailService _emailService, IAuthUserRepository _authUserRepository/*, IJobSeekerProfileRepository repository*/, HireMeNowDbContext context/*, IJobProviderService _jobProviderService*/)
        {
            jobSeekerRepository = _jobSeekerRepository;
            mapper = _mapper;
            emailService = _emailService;
            authUserRepository = _authUserRepository;
            //jobProviderService = _jobProviderService;
            //_repository = repository;
            _context = context;
        }

        public async void CreateSignupRequest(JobSeekerSignupRequestDto data)
        {
            var signUpRequest = mapper.Map<SignUpRequest>(data);
            var signUpId = jobSeekerRepository.AddSignupRequest(signUpRequest);
            MailRequest mailRequest = new MailRequest();

            mailRequest.Subject = "HireMeNow SignUp Verification";
            mailRequest.Body = signUpId.ToString();
            mailRequest.ToEmail = signUpRequest.Email;
            await emailService.SendEmailAsync(mailRequest);
        }

        public async Task<bool> VerifyEmailAsync(Guid jobSeekerSignupRequestId)
        {
            SignUpRequest signUpRequest = await jobSeekerRepository.GetSignupRequestByIdAsync(jobSeekerSignupRequestId);
            if (signUpRequest != null)
            {
                signUpRequest.Status = Status.VERIFIED;
                jobSeekerRepository.UpdateSignupRequest(signUpRequest);
                return true;
            }
            return false;
        }

        public async Task CreateJobseeker(Guid jobSeekerSignupRequestId, string password)
        {
            try
            {
                SignUpRequest signUpRequest = await jobSeekerRepository.GetSignupRequestByIdAsync(jobSeekerSignupRequestId);


                if (signUpRequest.Status == Status.VERIFIED)
                {
                    Domain.Models.AuthUser authUser = mapper.Map<Domain.Models.AuthUser>(signUpRequest);
                    authUser.Password = password;

                    authUser = await authUserRepository.AddAuthUserJS(authUser);
                    signUpRequest.Status = Status.CREATED;
                    jobSeekerRepository.UpdateSignupRequest(signUpRequest);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> ApplyJobAsync(Guid jobSeekerId, ApplyJobRequestDto requestDto)
        {
            try
            {
                var entity = mapper.Map<JobApplication>(requestDto);
                entity.Id = Guid.NewGuid();
                entity.Applicant = jobSeekerId;
                entity.Datesubmitted = DateTime.UtcNow;

                return await jobSeekerRepository.CreateJobApplicationAsync(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error applying job: " + ex.Message, ex);
            }
        }

        public async Task<bool> HasAlreadyAppliedAsync(Guid jobSeekerId, Guid jobPostId)
        {
            return await jobSeekerRepository.HasAlreadyAppliedAsync(jobSeekerId, jobPostId);
        }

        public async Task<List<AppliedJobDto>> GetAppliedJobsAsync(Guid jobSeekerId)
        {
            var appliedJobs = await jobSeekerRepository.GetAppliedJobsAsync(jobSeekerId);
            return appliedJobs.Select(j => new AppliedJobDto
            {
                JobApplicationId = j.Id,
                JobPostId = j.JobPost_id,
                JobTitle = j.JobPost.JobTitle,
                JobSummary = j.JobPost.JobSummary,
                PostedDate = j.JobPost.PostedDate,
                AppliedDate = j.Datesubmitted
            }).ToList();
        }

        public async Task<List<AppliedJobDto>> GetAppliedJobsByTitleAsync(Guid jobSeekerId, string jobTitle)
        {
            var appliedJobs = await jobSeekerRepository.GetAppliedJobsByTitleAsync(jobSeekerId, jobTitle);
            return appliedJobs.Select(j => new AppliedJobDto
            {
                JobApplicationId = j.Id,
                JobPostId = j.JobPost_id,
                JobTitle = j.JobPost.JobTitle,
                JobSummary = j.JobPost.JobSummary,
                PostedDate = j.JobPost.PostedDate,
                AppliedDate = j.Datesubmitted
            }).ToList();
        }

        public async Task<bool> CancelAppliedJobAsync(Guid jobSeekerId, Guid jobApplicationId)
        {
            return await jobSeekerRepository.CancelAppliedJobAsync(jobSeekerId, jobApplicationId);
        }

        public async Task<bool> SaveJobAsync(Guid jobSeekerId, SavedJobDto dto)
        {
            bool jobExists = await jobSeekerRepository.JobExistsAsync(dto.JobId);
            if (!jobExists)
                return false; 
            var savedJob = new SavedJob
            {
                Job = dto.JobId,
                SavedBy = jobSeekerId,
                DateSaved = DateTime.UtcNow
            };
            return await jobSeekerRepository.SaveJobAsync(savedJob);
        }

        public async Task<List<SavedJobDto>> GetSavedJobsAsync(Guid jobSeekerId)
        {
            var entities = await jobSeekerRepository.GetSavedJobsAsync(jobSeekerId);
            var result = entities.Select(s => new SavedJobDto
            {
                JobId = s.Job,            
                DateSaved = s.DateSaved
            }).ToList();
            return result;
        }


        public async Task<List<SavedJobDto>> GetSavedJobsByTitleAsync(Guid jobSeekerId, string title)
        {
            var entities = await jobSeekerRepository.GetSavedJobsByTitleAsync(jobSeekerId, title);
            return mapper.Map<List<SavedJobDto>>(entities);
        }

        public async Task<bool> RemoveSavedJobAsync(Guid jobSeekerId, Guid savedJobId)
        {
            return await jobSeekerRepository.RemoveSavedJobAsync(jobSeekerId, savedJobId);
        }

        public async Task<IEnumerable<InterviewDto>> GetScheduledInterviewsAsync(Guid jobSeekerId)
        {
            var interviews = await jobSeekerRepository.GetAllByJobSeekerIdAsync(jobSeekerId);
            return mapper.Map<IEnumerable<InterviewDto>>(interviews);
        }

        //public async Task <JobDto?> GetJobByTitleAsync(string title)
        //{
        //    var jobs = await _jobProviderService.GetAllJobsAsync();
        //    return jobs.FirstOrDefault(j=>j.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        //}
//=======
//using Azure.Core;
//using Domain.Models;
//using Domain.Service.JobSeeker.DTOs;
//using Domain.Service.JobSeeker.Interfaces;
//using Microsoft.EntityFrameworkCore;


//namespace Domain.Service.JobSeeker
//{
//    public  class JobSeekerService : IJobSeekerProfileService 
    //{
       // private readonly IJobSeekerProfileRepository _repository;
       //// private readonly IMapper _mapper;
       // private readonly HireMeNowDbContext _context;

        //public JobSeekerService(IJobSeekerProfileRepository repository, HireMeNowDbContext context)//,IMapper mapper
        //{
        //    _repository = repository;
        //   // _mapper = mapper;
        //    _context = context;
        //}

        public async Task<JobSeekerProfileDto> CreateProfileAsync(JobSeekerProfileDto seekerprofiledto, Guid jobSeekerId)
        {
            byte[]? imageData = null;
            byte[]? resumeData = null;

            bool profileExists = await jobSeekerRepository.JobSeekerProfileExistsAsync(jobSeekerId);
            if (profileExists)
                throw new InvalidOperationException("Profile already exists for this job seeker.");

            if (seekerprofiledto.SeekerImage != null)
            {
                using var ms = new MemoryStream();
                await seekerprofiledto.SeekerImage.CopyToAsync(ms);
                imageData = ms.ToArray();
            }

            if (seekerprofiledto.Resume != null)
            {
                using var ms = new MemoryStream();
                await seekerprofiledto.Resume.CopyToAsync(ms);
                resumeData = ms.ToArray();
            }

            var profile = new JobSeekerProfile
            {
                JobSeekerId = jobSeekerId, //seekerprofiledto.JobSeekerId,
                ProfileName = seekerprofiledto.ProfileName,
                ProfileSummary = seekerprofiledto.ProfileSummary,
                SeekerImage = imageData ?? Array.Empty<byte>(),
                Resume = resumeData ?? Array.Empty<byte>()
            };

            var created = await jobSeekerRepository.CreateJobseekerProfileAsync(profile);

            return new JobSeekerProfileDto
            {
                Id = created.Id,
                JobSeekerId = created.JobSeekerId,
                ProfileName = created.ProfileName,
                ProfileSummary = created.ProfileSummary
            };
        }


        public async Task<JobSeekerProfileDto> UpdateProfileAsync(JobSeekerProfileDto JobSeekerProfileDto, Guid jobSeekerId)
        {
            var profile = await jobSeekerRepository.GetByJobSeekerIdAsync(jobSeekerId);

            if (profile == null)
                throw new Exception("Profile not found for this Job Seeker.");

             
            if (!string.IsNullOrEmpty(JobSeekerProfileDto.ProfileName))
                profile.ProfileName = JobSeekerProfileDto.ProfileName;

            if (!string.IsNullOrEmpty(JobSeekerProfileDto.ProfileSummary))
                profile.ProfileSummary = JobSeekerProfileDto.ProfileSummary;

            if (JobSeekerProfileDto.SeekerImage != null)
            {
                using var ms = new MemoryStream();
                await JobSeekerProfileDto.SeekerImage.CopyToAsync(ms);
                profile.SeekerImage = ms.ToArray();
            }

            if (JobSeekerProfileDto.Resume != null)
            {
                using var ms = new MemoryStream();
                await JobSeekerProfileDto.Resume.CopyToAsync(ms);
                profile.Resume = ms.ToArray();
            }

            var updated = await jobSeekerRepository.UpdateJobseekerProfileAsync(profile);

            return new JobSeekerProfileDto
            {
                Id = updated.Id,
                JobSeekerId = updated.JobSeekerId,
                ProfileName = updated.ProfileName,
                ProfileSummary = updated.ProfileSummary
            };
        }


        public async Task<JobSeekerProfileDto?> PatchProfileAsync(JobSeekerProfileDto JobSeekerProfileDto, Guid jobSeekerId)
        {
            var profile = await jobSeekerRepository.GetByJobSeekerIdAsync(jobSeekerId);

            if (profile == null)
                return null;

            // Only update if a new value or file is provided
            if (!string.IsNullOrEmpty(JobSeekerProfileDto.ProfileName))
                profile.ProfileName = JobSeekerProfileDto.ProfileName;

            if (!string.IsNullOrEmpty(JobSeekerProfileDto.ProfileSummary))
                profile.ProfileSummary = JobSeekerProfileDto.ProfileSummary;

            if (JobSeekerProfileDto.SeekerImage != null)
            {
                using var ms = new MemoryStream();
                await JobSeekerProfileDto.SeekerImage.CopyToAsync(ms);
                profile.SeekerImage = ms.ToArray();
            }

            if (JobSeekerProfileDto.Resume != null)
            {
                using var ms = new MemoryStream();
                await JobSeekerProfileDto.Resume.CopyToAsync(ms);
                profile.Resume = ms.ToArray();
            }

            var updated = await jobSeekerRepository.UpdateJobseekerProfileAsync(profile);

            return new JobSeekerProfileDto
            {
                Id = updated.Id,
                JobSeekerId = updated.JobSeekerId,
                ProfileName = updated.ProfileName,
                ProfileSummary = updated.ProfileSummary
            };
        }

        public async Task<JobSeekerProfileViewDto?> GetProfileByJobSeekerIdAsync(Guid jobSeekerId)
        {
            var profile = await jobSeekerRepository.GetByJobSeekerIdAsync(jobSeekerId);

            if (profile == null)
                return null;

            return new JobSeekerProfileViewDto
            {
                Id = profile.Id,
                JobSeekerId = profile.JobSeekerId,
                ProfileName = profile.ProfileName,
                ProfileSummary = profile.ProfileSummary,
                ImageBase64 = profile.SeekerImage != null ? Convert.ToBase64String(profile.SeekerImage) : null,
                ResumeBase64 = profile.Resume != null ? Convert.ToBase64String(profile.Resume) : null
            };
        }


        public async Task<string> DeleteProfileAsync(Guid jobSeekerId)
        {
            
            var hasApplied = await jobSeekerRepository.HasAppliedJobsAsync(jobSeekerId);
            if (hasApplied)
                return "Cannot delete profile. JobSeeker has applied for one or more jobs.";

            
            var deleted = await jobSeekerRepository.DeleteProfileAsync(jobSeekerId);
            if (!deleted)
                return "Profile not found.";

            return "Profile deleted successfully.";
        }

        public async Task<byte[]?> GetResumeByJobSeekerIdAsync(Guid jobSeekerId)
        {
            return await jobSeekerRepository.GetResumeByJobSeekerIdAsync(jobSeekerId);
        }


        public async Task<List<Skill>> GetAllSkillsAsync()
        {
            return await jobSeekerRepository.GetAllSkillsAsync();
         }

        public async Task<string> AddSkillsToJobSeekerAsync(Guid jobSeekerId, List<Guid> skillIds)
        {
            var success = await jobSeekerRepository.AddSkillsToJobSeekerAsync(jobSeekerId, skillIds);
            return success ? "Skills added successfully." : "JobSeeker profile not found.";
        }


        public async Task<bool> UpdateSkillsAsync(Guid jobSeekerId, List<Guid> newSkillIds)
        {
            return await jobSeekerRepository.UpdateSkillsAsync(jobSeekerId, newSkillIds);
        }


        public async Task<bool> PatchSkillsAsync(Guid jobSeekerId, List<Guid> addSkillIds, List<Guid> removeSkillIds)
        {
            return await jobSeekerRepository.PatchSkillsAsync(jobSeekerId, addSkillIds, removeSkillIds);
        }

        public async Task<bool> DeleteSkillsAsync(Guid jobSeekerId, List<Guid> skillIds)
        {
            return await jobSeekerRepository.DeleteSkillsAsync(jobSeekerId, skillIds);
        }

        public async Task<List<SkillDto>> GetSkillsByJobSeekerIdAsync(Guid jobSeekerId)
        {
            var skills = await jobSeekerRepository.GetSkillsByJobSeekerIdAsync(jobSeekerId);
            return mapper.Map<List<SkillDto>>(skills);
        }

        public async Task<WorkExperienceDto> AddWorkExperienceAsync(Guid jobSeekerId, WorkExperienceDto dto)
        {
            
            var profile = await _context.JobSeekerProfiles
                .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);

            if (profile == null)
                throw new Exception("JobSeeker profile not found");

            var entity = mapper.Map<WorkExperience>(dto);
            entity.JobSeekerProfileId = profile.Id;
            entity.Id = Guid.NewGuid();

            await jobSeekerRepository.AddWorkExperiencesync(entity);
            await jobSeekerRepository.SaveChangesAsync();

            return mapper.Map<WorkExperienceDto>(entity);
        }

        public async Task<WorkExperienceDto> UpdateWorkExperienceAsync(Guid jobSeekerId, WorkExperienceDto dto)
        {
            var profile = await _context.JobSeekerProfiles
                .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);

            if (profile == null)
                throw new Exception("JobSeeker profile not found");

            var existing = await jobSeekerRepository.GetWorkExperienceByIdAsync(dto.Id);

            if (existing == null)
                throw new Exception("Work experience not found");

            
            if (existing.JobSeekerProfileId != profile.Id)
                throw new UnauthorizedAccessException("You can update only your own experiences.");

            
            existing.JobTitle = dto.JobTitle;
            existing.CompanyName = dto.CompanyName;
            existing.Summary = dto.Summary;
            existing.ServiceStart = dto.ServiceStart;
            existing.ServiceEnd = dto.ServiceEnd;

            await jobSeekerRepository.UpdateWorkExperienceAsync(existing);

            return mapper.Map<WorkExperienceDto>(existing);
        }


        public async Task<WorkExperienceDto> PatchWorkExperienceAsync(Guid jobSeekerId, WorkExperienceDto dto)
        {
            var profile = await _context.JobSeekerProfiles
                .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);

            if (profile == null)
                throw new Exception("JobSeeker profile not found.");

            var existing = await jobSeekerRepository.GetWorkExperienceByIdAsync(dto.Id);

            if (existing == null)
                throw new Exception("Work experience not found.");

            if (existing.JobSeekerProfileId != profile.Id)
                throw new UnauthorizedAccessException("You can only modify your own work experiences.");

            
            if (!string.IsNullOrEmpty(dto.JobTitle)) existing.JobTitle = dto.JobTitle;
            if (!string.IsNullOrEmpty(dto.CompanyName)) existing.CompanyName = dto.CompanyName;
            if (!string.IsNullOrEmpty(dto.Summary)) existing.Summary = dto.Summary;
            if (dto.ServiceStart != default) existing.ServiceStart = dto.ServiceStart;
            if (dto.ServiceEnd != default) existing.ServiceEnd = dto.ServiceEnd;

            await jobSeekerRepository.UpdateWorkExperienceAsync(existing);

            return mapper.Map<WorkExperienceDto>(existing);
        }

          public async Task<List<WorkExperienceDto>> GetWorkExperienceByJobSeekerIdAsync(Guid jobSeekerId)
        {
             var experiences = await jobSeekerRepository.GetBySeekerIdAsync(jobSeekerId);

             if (experiences == null || !experiences.Any())
              return new List<WorkExperienceDto>();

             return mapper.Map<List<WorkExperienceDto>>(experiences);
         }

        public async Task<bool> DeleteWorkExperienceAsync(Guid workExperienceId, Guid jobSeekerId)
        {
            var existing = await jobSeekerRepository.GetBySeekerWorkExperienceIdAsync(workExperienceId);

            if (existing == null)
                throw new KeyNotFoundException("Work experience not found.");

             
            if (existing.JobSeekerProfile.JobSeekerId != jobSeekerId)
                throw new UnauthorizedAccessException("You cannot delete another user's record.");

            return await jobSeekerRepository.DeleteWorkExperienceAsync(existing);
        }


        public async Task<QualificationDto> AddQualificationAsync(Guid jobSeekerId, QualificationDto qualificationDto)
        {

             
            var profile = await _context.JobSeekerProfiles.FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);
            if (profile == null)
                throw new Exception("Job seeker profile not found.");

            var entity = mapper.Map<Qualification>(qualificationDto);
            entity.JobseekerProfileId = profile.Id;
            entity.JobPostId = null; 

            var added = await jobSeekerRepository.AddQualificationAsync(entity);
            return mapper.Map<QualificationDto>(added);
        }



        public async Task<QualificationDto?> UpdateQualificationAsync(Guid qualificationId, Guid jobSeekerId, QualificationDto dto)
        {
            var existing = await jobSeekerRepository.GetQualificationByIdAsync(qualificationId);
            if (existing == null)
                throw new KeyNotFoundException("Qualification not found.");

            
            var profile = await _context.JobSeekerProfiles.FirstOrDefaultAsync(p => p.Id == existing.JobseekerProfileId);
            if (profile == null || profile.JobSeekerId != jobSeekerId)
                throw new UnauthorizedAccessException("You cannot edit another user's qualification.");

            
            existing.Name = dto.Name;
            existing.Description = dto.Description;
            existing.JobPostId = null; 

            await jobSeekerRepository.UpdateQualificationAsync(existing);

            return mapper.Map<QualificationDto>(existing);
        }


        public async Task<QualificationDto?> PatchQualificationAsync(Guid qualificationId, Guid jobSeekerId, QualificationDto dto)
        {
            var existing = await jobSeekerRepository.GetQualificationByIdAsync(qualificationId);
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

            await jobSeekerRepository.UpdateQualificationAsync(existing);

            return mapper.Map<QualificationDto>(existing);
        }

        public async Task<IEnumerable<QualificationDto>> GetQualificationsByJobSeekerIdAsync(Guid jobSeekerId)
        {
            var qualifications = await jobSeekerRepository.GetQualificationsByJobSeekerIdAsync(jobSeekerId);
            return mapper.Map<IEnumerable<QualificationDto>>(qualifications);
        }

        public async Task<bool> DeleteQualificationAsync(Guid qualificationId, Guid jobSeekerId)
        {
            var qualification = await jobSeekerRepository.GetQualificationDeleteByIdAsync(qualificationId);
            if (qualification == null)
                throw new KeyNotFoundException("Qualification not found.");

             
            if (qualification.JobSeekerProfile.JobSeekerId != jobSeekerId)
                throw new UnauthorizedAccessException("You are not allowed to delete this qualification.");

            return await jobSeekerRepository.DeleteQualificationAsync(qualification);
        }
//>>>>>>> 91486e349328fc03c64198fcaa7c9593b57a90c4
    }

}


