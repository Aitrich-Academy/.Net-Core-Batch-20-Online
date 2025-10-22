using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Service.JobSeeker.Interfaces
{
    public interface IJobSeekerRepository
    {
        Guid AddSignupRequest(SignUpRequest signUpRequest);
        Task<SignUpRequest> GetSignupRequestByIdAsync(Guid jobSeekerSignupRequestId);
        void UpdateSignupRequest(SignUpRequest signUpRequest);
        Task AddJobSeekerAsync(Models.JobSeeker jobseeker);
        Task<bool> CreateJobApplicationAsync(JobApplication jobApplication);
        Task<bool> HasAlreadyAppliedAsync(Guid jobSeekerId, Guid jobPostId);
        Task<List<JobApplication>> GetAppliedJobsAsync(Guid jobSeekerId);
        Task<List<JobApplication>> GetAppliedJobsByTitleAsync(Guid jobSeekerId, string jobTitle);
        Task<bool> CancelAppliedJobAsync(Guid jobSeekerId, Guid jobApplicationId);
        Task<bool> SaveJobAsync(SavedJob savedJob);
        Task<bool> JobExistsAsync(Guid jobId);
        Task<List<SavedJob>> GetSavedJobsAsync(Guid jobSeekerId);
        Task<List<SavedJob>> GetSavedJobsByTitleAsync(Guid jobSeekerId, string title);
        Task<bool> RemoveSavedJobAsync(Guid jobSeekerId, Guid savedJobId);
        Task<IEnumerable<Interview>> GetAllByJobSeekerIdAsync(Guid jobSeekerId);





        Task<JobSeekerProfile> CreateJobseekerProfileAsync(JobSeekerProfile profile);
        Task<JobSeekerProfile?> GetByJobSeekerIdAsync(Guid jobSeekerId);
        Task<JobSeekerProfile> UpdateJobseekerProfileAsync(JobSeekerProfile profile);

        Task<JobSeekerProfile?> ViewProfileByJobSeekerIdAsync(Guid jobSeekerId);

        Task<bool> HasAppliedJobsAsync(Guid jobSeekerId);
        Task<bool> DeleteProfileAsync(Guid jobSeekerId);

        Task<byte[]?> GetResumeByJobSeekerIdAsync(Guid jobSeekerId);


        Task<List<Skill>> GetAllSkillsAsync();
        Task<bool> AddSkillsToJobSeekerAsync(Guid jobSeekerId, List<Guid> skillIds);

        Task<bool> UpdateSkillsAsync(Guid jobSeekerId, List<Guid> newSkillIds);

        Task<bool> PatchSkillsAsync(Guid jobSeekerId, List<Guid> addSkillIds, List<Guid> removeSkillIds);

        Task<bool> DeleteSkillsAsync(Guid jobSeekerId, List<Guid> skillIds);

        Task<List<Skill>> GetSkillsByJobSeekerIdAsync(Guid jobSeekerId);



        Task AddWorkExperiencesync(WorkExperience experience);
        Task SaveChangesAsync();


        Task<WorkExperience?> GetWorkExperienceByIdAsync(Guid id);
        Task UpdateWorkExperienceAsync(WorkExperience experience);

        Task<List<WorkExperience>> GetBySeekerIdAsync(Guid jobSeekerId);

        Task<WorkExperience?> GetBySeekerWorkExperienceIdAsync(Guid id);
        Task<bool> DeleteWorkExperienceAsync(WorkExperience workExperience);

        Task<Qualification> AddQualificationAsync(Qualification qualification);


        Task<Qualification?> GetQualificationByIdAsync(Guid id);

        Task<bool> UpdateQualificationAsync(Qualification qualification);

        Task<IEnumerable<Qualification>> GetQualificationsByJobSeekerIdAsync(Guid jobSeekerId);

        Task<Qualification?> GetQualificationDeleteByIdAsync(Guid qualificationId);
        Task<bool> DeleteQualificationAsync(Qualification qualification);

        Task<bool> JobSeekerProfileExistsAsync(Guid jobSeekerId);
    }
}
