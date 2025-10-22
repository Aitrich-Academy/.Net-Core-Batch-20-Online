using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//<<<<<<< HEAD
using Domain.Enums;
//=======
//>>>>>>> 91486e349328fc03c64198fcaa7c9593b57a90c4
using Domain.Models;
using Domain.Service.JobSeeker.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Domain.Service.JobSeeker
{
//<<<<<<< HEAD
    public class JobSeekerRepository : IJobSeekerRepository
    {
        private readonly HireMeNowDbContext _context;

        public JobSeekerRepository(HireMeNowDbContext dbContext)
        {
            _context = dbContext;
        }
        public Guid AddSignupRequest(SignUpRequest signUpRequest)
        {
            signUpRequest.Status = Status.PENDING;
            _context.SignUpRequests.AddAsync(signUpRequest);
            _context.SaveChanges();
            return signUpRequest.Id;
        }

        public async Task<SignUpRequest> GetSignupRequestByIdAsync(Guid jobSeekerSignupRequestId)
        {
            return await _context.SignUpRequests.FindAsync(jobSeekerSignupRequestId);
        }

        public void UpdateSignupRequest(SignUpRequest signUpRequest)
        {
            _context.SignUpRequests.Update(signUpRequest);
            _context.SaveChanges();
        }

        public async Task AddJobSeekerAsync(Models.JobSeeker jobseeker)
        {
            await _context.JobSeekers.AddAsync(jobseeker);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CreateJobApplicationAsync(JobApplication jobApplication)
        {
            _context.JobApplications.Add(jobApplication);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> HasAlreadyAppliedAsync(Guid jobSeekerId, Guid jobPostId)
        {
            return await _context.JobApplications
                .AnyAsync(a => a.Applicant == jobSeekerId && a.JobPost_id == jobPostId);
        }

        public async Task<List<JobApplication>> GetAppliedJobsAsync(Guid jobSeekerId)
        {
            return await _context.JobApplications
                .Include(j => j.JobPost)
                .Where(j => j.Applicant == jobSeekerId)
                .ToListAsync();
        }

        public async Task<List<JobApplication>> GetAppliedJobsByTitleAsync(Guid jobSeekerId, string jobTitle)
        {
            return await _context.JobApplications
                .Include(j => j.JobPost)
                .Where(j => j.Applicant == jobSeekerId &&
                            j.JobPost.JobTitle.Contains(jobTitle))
                .ToListAsync();
        }

        public async Task<bool> CancelAppliedJobAsync(Guid jobSeekerId, Guid jobApplicationId)
        {
            try
            {
                var appliedJob = await _context.JobApplications
                    .FirstOrDefaultAsync(j => j.Id == jobApplicationId && j.Applicant == jobSeekerId);

                if (appliedJob == null)
                    return false;

                _context.JobApplications.Remove(appliedJob);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> JobExistsAsync(Guid jobId)
        {
            return await _context.JobPosts.AnyAsync(j => j.Id == jobId);
        }

        public async Task<bool> SaveJobAsync(SavedJob savedJob)
        {
            await _context.SavedJobs.AddAsync(savedJob);
            return await _context.SaveChangesAsync() > 0;
        }



        public async Task<List<SavedJob>> GetSavedJobsAsync(Guid jobSeekerId)
        {
            return await _context.SavedJobs
                .Include(s => s.JobPost)
                .Where(s => s.SavedBy == jobSeekerId)
                .ToListAsync();
        }

        public async Task<List<SavedJob>> GetSavedJobsByTitleAsync(Guid jobSeekerId, string title)
        {
            return await _context.SavedJobs
                .Include(s => s.JobPost)
                .Where(s => s.SavedBy == jobSeekerId && s.JobPost.JobTitle.Contains(title))
                .ToListAsync();
        }

        public async Task<bool> RemoveSavedJobAsync(Guid jobSeekerId, Guid savedJobId)
        {
            var entity = await _context.SavedJobs
                .FirstOrDefaultAsync(s => s.SavedBy == jobSeekerId && s.Id == savedJobId);
            if (entity != null)
            {
                _context.SavedJobs.Remove(entity);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }

        public async Task<IEnumerable<Interview>> GetAllByJobSeekerIdAsync(Guid jobSeekerId)
        {
            return await _context.Interviews
                .Include(i => i.Job)
                .Include(i => i.Company)
                .Where(i => i.interviewee == jobSeekerId)
                .ToListAsync();
        }


//=======
    //public  class JobSeekerRepository : IJobSeekerProfileRepository 
    //{
        //private readonly HireMeNowDbContext _context;

        //public JobSeekerRepository(HireMeNowDbContext context)
        //{
        //    _context = context;
        //}

        public async Task<JobSeekerProfile> CreateJobseekerProfileAsync(JobSeekerProfile profile)
        {
            _context.JobSeekerProfiles.Add(profile);
            await _context.SaveChangesAsync();
             return profile;
        }

        public async Task<JobSeekerProfile?> GetByJobSeekerIdAsync(Guid jobSeekerId)
        {
            return await _context.JobSeekerProfiles
                .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);
        }

        public async Task<JobSeekerProfile> UpdateJobseekerProfileAsync(JobSeekerProfile profile)
        {
            _context.JobSeekerProfiles.Update(profile);
            await _context.SaveChangesAsync();
            return profile;
        }

        public async Task<JobSeekerProfile?> ViewProfileByJobSeekerIdAsync(Guid jobSeekerId)
        {
            return await _context.JobSeekerProfiles
                .Include(p => p.JobSeekerProfileSkills)
                .Include(p => p.Qualifications)
                .Include(p => p.WorkExperiences)
                .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);
        }

        public async Task<bool> HasAppliedJobsAsync(Guid jobSeekerId)
        {
            return await _context.JobApplications
                .AnyAsync(a => a.Applicant == jobSeekerId);
        }

        public async Task<bool> DeleteProfileAsync(Guid jobSeekerId)
        {
            var profile = await _context.JobSeekerProfiles
                .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);

            if (profile == null)
                return false;

            _context.JobSeekerProfiles.Remove(profile);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<byte[]?> GetResumeByJobSeekerIdAsync(Guid jobSeekerId)
        {
            var profile = await _context.JobSeekerProfiles
                .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);

            return profile?.Resume;
        }


        public async Task<List<Skill>> GetAllSkillsAsync()
        {
            return await _context.Skills.ToListAsync();
        }

        public async Task<bool> AddSkillsToJobSeekerAsync(Guid jobSeekerId, List<Guid> skillIds)
        {
            var profile = await _context.JobSeekerProfiles
                .Include(p => p.JobSeekerProfileSkills)
                .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);

            if (profile == null)
                return false;

             
           _context.JobSeekerProfileSkills.RemoveRange(profile.JobSeekerProfileSkills);

            
            foreach (var skillId in skillIds)
            {
                var skillExists = await _context.Skills.AnyAsync(s => s.Id == skillId);
                if (skillExists)
                {
                    profile.JobSeekerProfileSkills.Add(new JobSeekerProfileSkill
                    {
                        JobSeekerProfileId = profile.Id,
                        SkillId = skillId
                    });
                }
            }

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateSkillsAsync(Guid jobSeekerId, List<Guid> newSkillIds)
        {
            var profile = await _context.JobSeekerProfiles
                .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);

            if (profile == null)
                return false;

            
            var existingSkills = await _context.JobSeekerProfileSkills
                .Where(x => x.JobSeekerProfileId == profile.Id)
                .ToListAsync();

            
            _context.JobSeekerProfileSkills.RemoveRange(existingSkills);

            
            foreach (var skillId in newSkillIds.Distinct())
            {
                _context.JobSeekerProfileSkills.Add(new JobSeekerProfileSkill
                {
                    JobSeekerProfileId = profile.Id,
                    SkillId = skillId
                });
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> PatchSkillsAsync(Guid jobSeekerId, List<Guid> addSkillIds, List<Guid> removeSkillIds)
        {
            var profile = await _context.JobSeekerProfiles
                .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);

            if (profile == null)
                return false;

            
            if (removeSkillIds != null && removeSkillIds.Any())
            {
                var skillsToRemove = await _context.JobSeekerProfileSkills
                    .Where(x => x.JobSeekerProfileId == profile.Id && removeSkillIds.Contains(x.SkillId))
                    .ToListAsync();

                _context.JobSeekerProfileSkills.RemoveRange(skillsToRemove);
            }

           
            if (addSkillIds != null && addSkillIds.Any())
            {
                foreach (var skillId in addSkillIds.Distinct())
                {
                    bool exists = await _context.JobSeekerProfileSkills
                        .AnyAsync(x => x.JobSeekerProfileId == profile.Id && x.SkillId == skillId);

                    if (!exists)
                    {
                        _context.JobSeekerProfileSkills.Add(new JobSeekerProfileSkill
                        {
                            JobSeekerProfileId = profile.Id,
                            SkillId = skillId
                        });
                    }
                }
            }

            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> DeleteSkillsAsync(Guid jobSeekerId, List<Guid> skillIds)
        {
            var profile = await _context.JobSeekerProfiles
                .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);

            if (profile == null)
                return false;

            if (skillIds == null || !skillIds.Any())
                return false;

            var skillsToRemove = await _context.JobSeekerProfileSkills
                .Where(x => x.JobSeekerProfileId == profile.Id && skillIds.Contains(x.SkillId))
                .ToListAsync();

            if (!skillsToRemove.Any())
                return false;

            _context.JobSeekerProfileSkills.RemoveRange(skillsToRemove);
            await _context.SaveChangesAsync();

            return true;
        }


        public async Task<List<Skill>> GetSkillsByJobSeekerIdAsync(Guid jobSeekerId)
        {
            var profile = await _context.JobSeekerProfiles
                .FirstOrDefaultAsync(p => p.JobSeekerId == jobSeekerId);

            if (profile == null)
                return new List<Skill>();

            var skills = await _context.JobSeekerProfileSkills
                .Include(x => x.Skill)
                .Where(x => x.JobSeekerProfileId == profile.Id)
                .Select(x => x.Skill)
                .ToListAsync();

            return skills;
        }


        public async Task AddWorkExperiencesync(WorkExperience experience)
        {
            await _context.WorkExperiences.AddAsync(experience);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<WorkExperience?> GetWorkExperienceByIdAsync(Guid id)
        {
            return await _context.WorkExperiences.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateWorkExperienceAsync(WorkExperience experience)
        {
            _context.WorkExperiences.Update(experience);
            await _context.SaveChangesAsync();
        }

        public async Task<List<WorkExperience>> GetBySeekerIdAsync(Guid jobSeekerId)
        {
            return await _context.WorkExperiences
                .Include(w => w.JobSeekerProfile)
                .Where(w => w.JobSeekerProfile.JobSeekerId == jobSeekerId)
                .ToListAsync();
        }

        public async Task<WorkExperience?> GetBySeekerWorkExperienceIdAsync(Guid id)
        {
            return await _context.WorkExperiences
                .Include(w => w.JobSeekerProfile)
                .FirstOrDefaultAsync(w => w.Id == id);
        }

        public async Task<bool> DeleteWorkExperienceAsync(WorkExperience workExperience)
        {
            _context.WorkExperiences.Remove(workExperience);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Qualification> AddQualificationAsync(Qualification qualification)
        {
            qualification.JobPostId = null;

            if (qualification.Id == Guid.Empty)
                qualification.Id = Guid.NewGuid();

            _context.Qualifications.Add(qualification);
            await _context.SaveChangesAsync();
            return qualification;
        }

      
        public async Task<Qualification?> GetQualificationByIdAsync(Guid id)
        {
            return await _context.Qualifications.FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task<bool> UpdateQualificationAsync(Qualification qualification)
        {
            _context.Qualifications.Update(qualification);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Qualification>> GetQualificationsByJobSeekerIdAsync(Guid jobSeekerId)
        {
            return await _context.Qualifications
                .Include(q => q.JobSeekerProfile)
                .Where(q => q.JobSeekerProfile.JobSeekerId == jobSeekerId)
                .ToListAsync();
        }

        public async Task<Qualification?> GetQualificationDeleteByIdAsync(Guid qualificationId)
        {
            return await _context.Qualifications
                .Include(q => q.JobSeekerProfile)
                .FirstOrDefaultAsync(q => q.Id == qualificationId);
        }

        public async Task<bool> DeleteQualificationAsync(Qualification qualification)
        {
            _context.Qualifications.Remove(qualification);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> JobSeekerProfileExistsAsync(Guid jobSeekerId)
        {
            return await _context.JobSeekerProfiles
                .AnyAsync(p => p.JobSeekerId == jobSeekerId);
        }

//>>>>>>> 91486e349328fc03c64198fcaa7c9593b57a90c4
    }
}
