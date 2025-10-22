//<<<<<<< HEAD
﻿using System.Security.Claims;
using AutoMapper;
using Domain.Service.Authuser;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.JobSeeker;
using Domain.Service.JobSeeker.DTOs;
using Domain.Service.JobSeeker.Interfaces;
using Domain.Service.Login.Interfaces;
using Job_Portal.API.JobSeeker.RequestObjects;
using Microsoft.AspNetCore.Authorization;
//=======
﻿using Domain.Models;
using Domain.Service.JobSeeker.Interfaces;
using Job_Portal.API.JobSeeker.RequestObjects;
//>>>>>>> 91486e349328fc03c64198fcaa7c9593b57a90c4
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Domain.Service.JobSeeker.DTOs;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Job_Portal.API.JobSeeker
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobSeekerController : ControllerBase
    {
//<<<<<<< HEAD
        public IJobSeekerService jobSeekerService { get; set; }

        //public IJobProviderService jobProviderService;
        public ILoginRequestService loginRequestService { get; set; }
        public IAuthUserService  authUserService { get; set; }
        public IMapper mapper { get; set; }
        public JobSeekerController(IJobSeekerService _jobSeekerService, IMapper _mapper, ILoginRequestService _loginRequestService, IAuthUserService _authUserService/*, IJobProviderService _jobProviderService*/)
        {
            jobSeekerService = _jobSeekerService;
            loginRequestService = _loginRequestService;
            authUserService = _authUserService;
            mapper = _mapper;
            //jobProviderService = _jobProviderService;
        }


        [HttpPost]
        [Route("job-seeker/signup")]
        public async Task<ActionResult> createJobSeekerSignupRequest(JobSeekerSignupRequest data)
        {
            var jobSeekerSignupRequestDto = mapper.Map<JobSeekerSignupRequestDto>(data);
            jobSeekerService.CreateSignupRequest(jobSeekerSignupRequestDto);
            return Ok(data);
        }

        [HttpGet]
        [Route("job-seeker/signup/{jobSeekerSignupRequestId}/verify-email")]
        public async Task<ActionResult> VerifyJobSeekerEmail(Guid jobSeekerSignupRequestId)
        {
            var isVerified = await jobSeekerService.VerifyEmailAsync(jobSeekerSignupRequestId);
            if (isVerified)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("job-seeker/signup/{jobSeekerSignupRequestId}/set-password")]
        public async Task<ActionResult> createJobSeekerSignupRequest(Guid jobSeekerSignupRequestId, [FromBody] string password)
        {
            await jobSeekerService.CreateJobseeker(jobSeekerSignupRequestId, password);
            return Ok("Password Set Successfully");
        }

        [HttpPost]
        [Route("job-seeker/login")]
        public async Task<ActionResult> Login([FromBody] JobSeekerLoginRequest logdata)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid login request.");

            var user = await loginRequestService.LoginJS(logdata.Email, logdata.Password);

            if (user == null)
                return Unauthorized("Invalid email or password.");

            return Ok(user);
        }

        [Authorize]
        [HttpPost]
        [Route("job-seeker/job-application")]
        public async Task<IActionResult> ApplyJob([FromBody] ApplyJobRequest request)
        {
            var userId = authUserService.GetUserId();
            var jobSeekerId = Guid.Parse(userId);

            bool alreadyApplied = await jobSeekerService.HasAlreadyAppliedAsync(jobSeekerId, request.JobPost_Id);
            if (alreadyApplied)
                return BadRequest(new { message = "You have already applied for this job." });

            var dto = mapper.Map<ApplyJobRequestDto>(request);
            var result = await jobSeekerService.ApplyJobAsync(jobSeekerId, dto);

            if (result)
                return Ok(new { message = "Job Applied Successfully" });

            return BadRequest(new { message = "Failed to apply for job." });
        }


        [Authorize]
        [HttpGet]
        [Route("job-seeker/applied-jobs")]
        public async Task<IActionResult> GetAppliedJobs()
        {
            var userId = authUserService.GetUserId();
            var jobSeekerId = Guid.Parse(userId);

            var appliedJobs = await jobSeekerService.GetAppliedJobsAsync(jobSeekerId);
            return Ok(appliedJobs);
        }

        [Authorize]
        [HttpGet]
        [Route("job-seeker/applied-jobs/search")]
        public async Task<IActionResult> GetAppliedJobsByTitle([FromQuery] string title)
        {
            var userId = authUserService.GetUserId();
            var jobSeekerId = Guid.Parse(userId);

            var appliedJobs = await jobSeekerService.GetAppliedJobsByTitleAsync(jobSeekerId, title);
            return Ok(appliedJobs);
        }

        [Authorize]
        [HttpDelete]
        [Route("job-seeker/job-application/{jobApplicationId}/cancel")]
        public async Task<IActionResult> CancelAppliedJob(Guid jobApplicationId)
        {
            var jobSeekerId = Guid.Parse(authUserService.GetUserId());

            var result = await jobSeekerService.CancelAppliedJobAsync(jobSeekerId, jobApplicationId);

            if (result)
                return Ok(new { Message = "Application cancelled successfully." });

            return NotFound(new { Message = "Application not found or does not belong to the user." });
        }

        [Authorize]
        [HttpPost("job-seeker/SaveJob/{jobId}")]
        public async Task<IActionResult> SaveJob(Guid jobId)
        {
            var jobSeekerId = new Guid(authUserService.GetUserId());

            var dto = new SavedJobDto
            {
                JobId = jobId,
                DateSaved = DateTime.UtcNow
            };
            var result = await jobSeekerService.SaveJobAsync(jobSeekerId, dto);
            if (result)
                return Ok("Job saved successfully");

            return BadRequest("Job does not exist or could not be saved.");
        }



        [Authorize]
        [HttpGet("saved-jobs")]
        public async Task<IActionResult> GetSavedJobs()
        {
            var jobSeekerId = Guid.Parse(authUserService.GetUserId());
            var result = await jobSeekerService.GetSavedJobsAsync(jobSeekerId);
            return Ok(result);
        }


        [Authorize]
        [HttpGet("saved-jobs/search")]
        public async Task<IActionResult> GetSavedJobsByTitle([FromQuery] string title)
        {
            var jobSeekerId = Guid.Parse(authUserService.GetUserId());
            var result = await jobSeekerService.GetSavedJobsByTitleAsync(jobSeekerId, title);
            return Ok(result);
        }
//=======
       // private readonly IJobSeekerProfileService _profileService;
       //// private readonly IMapper _mapper;

        //public JobSeekerController(IJobSeekerProfileService profileService)//, IMapper mapper)
        //{
        //    _profileService = profileService;
           // _mapper = mapper;
        //}

      //  [Authorize(Roles = "JobSeeker")]
        [HttpPost("create")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> CreateProfile([FromForm] CreateJobSeekerProfileRequest request)
        {
             var jobSeekerId = User.FindFirstValue(ClaimTypes.NameIdentifier);  
                                                                                    // Guid jobSeekerId = Guid.Parse("71A50ED5-C020-4301-8D1D-F1FE71C611BA");
           var seekerId=User.FindFirst("JobSeekerId")?.Value;
            if (jobSeekerId == null)
                return Unauthorized("Invalid or missing JobSeeker ID in token.");
            var seekerprofiledto = mapper.Map<JobSeekerProfileDto>(request);
            var result = await jobSeekerService.CreateProfileAsync(seekerprofiledto,Guid.Parse(jobSeekerId));
            return Ok(result);
        }

      //  [Authorize(Roles = "JobSeeker")]
        [HttpPut("update")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> UpdateProfile([FromForm] UpdateJobSeekerProfileRequest request)
        {
            var jobSeekerId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                                                                                                   

            if (jobSeekerId == null)
                return Unauthorized("Invalid or missing JobSeeker ID in token.");

            var seekerprofiledto = mapper.Map<JobSeekerProfileDto>(request);

            var result = await jobSeekerService.UpdateProfileAsync(seekerprofiledto, Guid.Parse(jobSeekerId));
            return Ok(result);
        }

        //[Authorize(Roles = "JobSeeker")]
        [HttpPatch("patch")]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> PatchProfile([FromForm] PatchJobSeekerProfileRequest request)
        {
             var jobSeekerId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                                                                                   

            if (jobSeekerId == null)
                return Unauthorized("Invalid or missing JobSeeker ID in token.");

            var seekerprofiledto = mapper.Map<JobSeekerProfileDto>(request);

            var result = await jobSeekerService.PatchProfileAsync(seekerprofiledto, Guid.Parse(jobSeekerId));

            if (result == null)
                return NotFound("Profile not found for this Job Seeker.");

            return Ok(result);
        }

        //[Authorize(Roles = "JobSeeker")]
        [HttpGet("view")]
        public async Task<IActionResult> GetMyProfile()
        {
            var jobSeekerId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                                                                     

            if (jobSeekerId == null)
                return Unauthorized("Invalid or missing JobSeeker ID in token.");

            var result = await jobSeekerService.GetProfileByJobSeekerIdAsync(Guid.Parse(jobSeekerId));

            if (result == null)
                return NotFound("Profile not found for this Job Seeker.");

            return Ok(result);
        }

       // [Authorize(Roles = "JobSeeker")]
        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteMyProfile()
        {
             
           var jobSeekerId = User.FindFirstValue(ClaimTypes.NameIdentifier);

             

            if (string.IsNullOrEmpty(jobSeekerId))
                return Unauthorized("Invalid or missing JobSeeker ID in token.");

            var result = await jobSeekerService.DeleteProfileAsync(Guid.Parse(jobSeekerId));

             
            if (result.Contains("Cannot delete"))
                return BadRequest(result);
            if (result.Contains("not found"))
                return NotFound(result);

            return Ok(result);
        }

      //  [Authorize(Roles = "JobSeeker")]
        [HttpGet("view-resume")]
        public async Task<IActionResult> ViewMyResume()
        {
            var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
 
            if (string.IsNullOrEmpty(jobSeekerIdClaim))
                return Unauthorized("Invalid token or missing JobSeeker ID.");

            Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);
             
            if (jobSeekerId == null)
                return Unauthorized("Invalid or missing JobSeeker ID in token.");

            var resumeData = await jobSeekerService.GetResumeByJobSeekerIdAsync(jobSeekerId);
            if (resumeData == null)
                return NotFound("Resume not found for this JobSeeker.");

            
            string contentType = "application/pdf"; // default to PDF
            return File(resumeData, contentType, "Resume.pdf");
        }

      //  [Authorize]
        [HttpGet("all-skills")]
        public async Task<IActionResult> GetAllSkills()
        {
            var skills = await jobSeekerService.GetAllSkillsAsync();
            return Ok(skills.Select(s => new { s.Id, s.Name, s.Description }));
        }

        //  [Authorize(Roles = "JobSeeker")]
        [HttpPost("add-skills")]
        public async Task<IActionResult> AddSkills([FromBody] AddJobSeekerSkillsRequest request)
        {

            var Skilldto = mapper.Map<JobseekerProfileSkillDto>(request); 

            if (Skilldto.SkillIds == null || request.SkillIds.Count == 0)
                return BadRequest("Please select at least one skill.");

            var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(jobSeekerIdClaim))
                return Unauthorized("Invalid or missing JobSeeker ID.");

            

             Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

            var result = await jobSeekerService.AddSkillsToJobSeekerAsync(jobSeekerId, Skilldto.SkillIds);
            return Ok(result);
        }

        //[Authorize(Roles = "JobSeeker")]
        [HttpPut("skills")]
        public async Task<IActionResult> UpdateSkills([FromBody] UpdateSkillsRequest request)
        {
            var Skilldto = mapper.Map<JobseekerProfileSkillDto>(request);

            if (Skilldto.SkillIds == null || !request.SkillIds.Any())
                return BadRequest("Please select at least one skill.");
 

            var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(jobSeekerIdClaim))
                return Unauthorized();

            Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

            bool success = await jobSeekerService.UpdateSkillsAsync(jobSeekerId, Skilldto.SkillIds);

            if (!success)
                return NotFound("JobSeeker profile not found.");

            return Ok("Skills updated successfully.");
        }

       // [Authorize(Roles = "JobSeeker")]
        [HttpPatch("skills")]
        public async Task<IActionResult> PatchSkills([FromBody] PatchSkillsRequest request)
        {
            if ((request.AddSkillIds == null || !request.AddSkillIds.Any()) &&
                (request.RemoveSkillIds == null || !request.RemoveSkillIds.Any()))
            {
                return BadRequest("Please provide skills to add or remove.");
            }

          
            var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(jobSeekerIdClaim))
                return Unauthorized();

            Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

            bool success = await jobSeekerService.PatchSkillsAsync(jobSeekerId, request.AddSkillIds, request.RemoveSkillIds);

            if (!success)
                return NotFound("JobSeeker profile not found.");

            return Ok("Skills updated successfully (patch).");
        }

       // [Authorize(Roles = "JobSeeker")]
        [HttpDelete("skills")]
        public async Task<IActionResult> DeleteSkills([FromBody] DeleteSkillsRequest request)
        {
            if (request.SkillIds == null || !request.SkillIds.Any())
                return BadRequest("Please provide at least one skill ID to delete.");

            


            Guid jobSeekerId = Guid.Parse("71A50ED5-C020-4301-8D1D-F1FE71C611BA");

            if (jobSeekerId == null)
                return Unauthorized("Invalid or missing JobSeeker ID in token.");

            bool success = await jobSeekerService.DeleteSkillsAsync(jobSeekerId, request.SkillIds);

            if (!success)
                return NotFound("No matching skills found for deletion.");

            return Ok("Selected skills deleted successfully.");
        }

       // [Authorize(Roles = "JobSeeker")]
        [HttpGet("skills")]
        public async Task<IActionResult> GetJobSeekerSkills()
        {
            var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(jobSeekerIdClaim))
                return Unauthorized();

            Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

           

            var skills = await jobSeekerService.GetSkillsByJobSeekerIdAsync(jobSeekerId);

            if (skills == null || !skills.Any())
                return Ok(new List<SkillDto>());

            return Ok(skills);
        }


        [HttpPost("AddWorkExperience")]
        public async Task<IActionResult> AddWorkExperience([FromBody] AddWorkExperienceRequest request)
        {
            var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(jobSeekerIdClaim))
                return Unauthorized();

            Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

           

            var dto = mapper.Map<WorkExperienceDto>(request);
            var result = await jobSeekerService.AddWorkExperienceAsync(jobSeekerId, dto);

            return Ok(result);
        }


        [HttpPut("UpdateWorkExperience")]
        public async Task<IActionResult> UpdateWorkExperience([FromBody] UpdateWorkExperienceRequest request)
        {
            var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(jobSeekerIdClaim))
                return Unauthorized();

            Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

          

            var dto = mapper.Map<WorkExperienceDto>(request);
            var result = await jobSeekerService.UpdateWorkExperienceAsync(jobSeekerId, dto);

            return Ok(result);
        }


        [HttpPatch("PatchWorkExperience")]
        public async Task<IActionResult> PatchWorkExperience([FromBody] PatchWorkExperienceRequest request)
        {
            var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(jobSeekerIdClaim))
                return Unauthorized();

            Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

            

            var dto = mapper.Map<WorkExperienceDto>(request);
            var result = await jobSeekerService.PatchWorkExperienceAsync(jobSeekerId, dto);

            return Ok(result);
        }

        [HttpGet("ViewWorkexperience")]
        public async Task<IActionResult> ViewWorkExperience()
        {
            var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(jobSeekerIdClaim))
                return Unauthorized();

            Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

           

            var result = await jobSeekerService.GetWorkExperienceByJobSeekerIdAsync(jobSeekerId);

            if (result == null || !result.Any())
                return NotFound("No work experience found for this job seeker.");

            return Ok(result);
        }

        [HttpDelete("DeleteWorkexperience")]
        public async Task<IActionResult> DeleteWorkExperience(Guid id)
        {
            try
            {
                var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(jobSeekerIdClaim))
                    return Unauthorized();

                Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

               

                bool deleted = await jobSeekerService.DeleteWorkExperienceAsync(id, jobSeekerId);

                if (!deleted)
                    return BadRequest("Failed to delete work experience.");

                return Ok("Work experience deleted successfully.");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Forbid(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }


        [HttpPost("AddQualification")]
        public async Task<IActionResult> AddQualification([FromBody] QualificationAddRequest request)
        {
            var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(jobSeekerIdClaim))
                return Unauthorized("Job seeker ID not found in token.");

            Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

             

            var dto = mapper.Map<QualificationDto>(request);
            var result = await jobSeekerService.AddQualificationAsync(jobSeekerId, dto);
//>>>>>>> 91486e349328fc03c64198fcaa7c9593b57a90c4

            return Ok(result);
        }

//<<<<<<< HEAD
        [Authorize]
        [HttpDelete("saved-job/{savedJobId}/remove")]
        public async Task<IActionResult> RemoveSavedJob(Guid savedJobId)
        {
            var jobSeekerId = Guid.Parse(authUserService.GetUserId());
            var result = await jobSeekerService.RemoveSavedJobAsync(jobSeekerId, savedJobId);

            if (result)
                return Ok(new { Message = "Saved job removed successfully" });

            return NotFound(new { Message = "Saved job not found" });
        }


        [HttpGet("scheduled-interviews")]
        [Authorize]
        public async Task<IActionResult> GetScheduledInterviews()
        {
            var userIdString = authUserService.GetUserId();

            if (string.IsNullOrEmpty(userIdString) || !Guid.TryParse(userIdString, out Guid jobSeekerId))
                return Unauthorized("Invalid user ID.");

            var interviews = await jobSeekerService.GetScheduledInterviewsAsync(jobSeekerId);

            if (interviews == null || !interviews.Any())
                return NotFound("No scheduled interviews found.");

            return Ok(interviews);
        }

        [HttpPost("logout")]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            var userIdString = authUserService.GetUserId();

            if (string.IsNullOrEmpty(userIdString) || !Guid.TryParse(userIdString, out Guid userId))
                return Unauthorized("Invalid user ID.");

            await authUserService.LogoutAsync(userId);
            return Ok("Logout successful.");
        }



        //[HttpGet("GetAllJobs")]
        //public async Task<IActionResult> GetAllJobs()
        //{
        //    var jobs = await jobProviderService.GetAllJobsAsync();
        //    if (jobs == null || !jobs.Any())
        //        return NotFound("No jobs found.");

        //    return Ok(jobs);
        //}

        //[HttpGet("GetJobById/{id}")]
        //public async Task<IActionResult> GetJobById(Guid id)
        //{
        //    var job = await jobProviderService.GetJobByIdAsync(id);
        //    if (job == null)
        //        return NotFound("Job not found.");

        //    return Ok(job);
        //}

        //[HttpGet("GetJobByTitle/{title}")]
        //public async Task<IActionResult> GetJobByTitle(string title)
        //{
        //    var job = await jobSeekerService.GetJobByTitleAsync(title);
        //    if (job == null)
        //        return NotFound("Job not found.");

        //    return Ok(job);
        //}

//=======
        [HttpPut("UpdateQualification/{id}")]
        public async Task<IActionResult> UpdateQualification(Guid id, [FromBody] QualificationUpdateRequest request)
        {
            try
            {
                var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(jobSeekerIdClaim))
                    return Unauthorized("Job seeker ID not found in token.");

                Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

               

                var dto = mapper.Map<QualificationDto>(request);
                var updated = await jobSeekerService.UpdateQualificationAsync(id, jobSeekerId, dto);

                if (updated == null)
                    return NotFound("Qualification not found.");

                return Ok(updated);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Forbid(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPatch("PatchQualification/{id}")]
        public async Task<IActionResult> PatchQualification(Guid id,QualificationPatchRequest request)
        {
            try
            {
                var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(jobSeekerIdClaim))
                    return Unauthorized("Job seeker ID not found in token.");

                Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

               

                var dto = mapper.Map<QualificationDto>(request);
                var updated = await jobSeekerService.PatchQualificationAsync(id, jobSeekerId, dto);

                if (updated == null)
                    return NotFound("Qualification not found.");

                return Ok(updated);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Forbid(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpGet("ViewQualification")]
        public async Task<IActionResult> ViewQualifications()
        {
            try
            {
               
                var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(jobSeekerIdClaim))
                    return Unauthorized("Job seeker ID not found in token.");

                Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

                 

                var result = await jobSeekerService.GetQualificationsByJobSeekerIdAsync(jobSeekerId);

                if (result == null || !result.Any())
                    return NotFound("No qualifications found for this job seeker.");

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpDelete("DeleteQualification/{qualificationId}")]
        public async Task<IActionResult> DeleteQualification(Guid qualificationId)
        {
            try
            {
                var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(jobSeekerIdClaim))
                    return Unauthorized("Job seeker ID not found in token.");

                Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

                //Guid jobSeekerId = Guid.Parse("71A50ED5-C020-4301-8D1D-F1FE71C611BA");

                //if (jobSeekerId == null)

                //    return Unauthorized("Invalid or missing JobSeeker ID in token.");

                var result = await jobSeekerService.DeleteQualificationAsync(qualificationId, jobSeekerId);
                if (!result)
                    return BadRequest("Failed to delete qualification.");

                return Ok("Qualification deleted successfully.");
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Forbid(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
//>>>>>>> 91486e349328fc03c64198fcaa7c9593b57a90c4
    }
}
 

