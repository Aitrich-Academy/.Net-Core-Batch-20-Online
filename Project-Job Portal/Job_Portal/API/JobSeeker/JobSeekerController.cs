using Domain.Models;
using Domain.Service.JobSeeker.Interfaces;
using Job_Portal.API.JobSeeker.RequestObjects;
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
        private readonly IJobSeekerProfileService _profileService;
       // private readonly IMapper _mapper;

        public JobSeekerController(IJobSeekerProfileService profileService)//, IMapper mapper)
        {
            _profileService = profileService;
           // _mapper = mapper;
        }

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
            var seekerprofiledto = _mapper.Map<JobSeekerProfileDto>(request);
            var result = await _profileService.CreateProfileAsync(seekerprofiledto,Guid.Parse(jobSeekerId));
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

            var seekerprofiledto = _mapper.Map<JobSeekerProfileDto>(request);

            var result = await _profileService.UpdateProfileAsync(seekerprofiledto, Guid.Parse(jobSeekerId));
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

            var seekerprofiledto = _mapper.Map<JobSeekerProfileDto>(request);

            var result = await _profileService.PatchProfileAsync(seekerprofiledto, Guid.Parse(jobSeekerId));

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

            var result = await _profileService.GetProfileByJobSeekerIdAsync(Guid.Parse(jobSeekerId));

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

            var result = await _profileService.DeleteProfileAsync(Guid.Parse(jobSeekerId));

             
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

            var resumeData = await _profileService.GetResumeByJobSeekerIdAsync(jobSeekerId);
            if (resumeData == null)
                return NotFound("Resume not found for this JobSeeker.");

            
            string contentType = "application/pdf"; // default to PDF
            return File(resumeData, contentType, "Resume.pdf");
        }

      //  [Authorize]
        [HttpGet("all-skills")]
        public async Task<IActionResult> GetAllSkills()
        {
            var skills = await _profileService.GetAllSkillsAsync();
            return Ok(skills.Select(s => new { s.Id, s.Name, s.Description }));
        }

        //  [Authorize(Roles = "JobSeeker")]
        [HttpPost("add-skills")]
        public async Task<IActionResult> AddSkills([FromBody] AddJobSeekerSkillsRequest request)
        {

            var Skilldto = _mapper.Map<JobseekerProfileSkillDto>(request); 

            if (Skilldto.SkillIds == null || request.SkillIds.Count == 0)
                return BadRequest("Please select at least one skill.");

            var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(jobSeekerIdClaim))
                return Unauthorized("Invalid or missing JobSeeker ID.");

            

             Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

            var result = await _profileService.AddSkillsToJobSeekerAsync(jobSeekerId, Skilldto.SkillIds);
            return Ok(result);
        }

        //[Authorize(Roles = "JobSeeker")]
        [HttpPut("skills")]
        public async Task<IActionResult> UpdateSkills([FromBody] UpdateSkillsRequest request)
        {
            var Skilldto = _mapper.Map<JobseekerProfileSkillDto>(request);

            if (Skilldto.SkillIds == null || !request.SkillIds.Any())
                return BadRequest("Please select at least one skill.");
 

            var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(jobSeekerIdClaim))
                return Unauthorized();

            Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

            bool success = await _profileService.UpdateSkillsAsync(jobSeekerId, Skilldto.SkillIds);

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

            bool success = await _profileService.PatchSkillsAsync(jobSeekerId, request.AddSkillIds, request.RemoveSkillIds);

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

            bool success = await _profileService.DeleteSkillsAsync(jobSeekerId, request.SkillIds);

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

           

            var skills = await _profileService.GetSkillsByJobSeekerIdAsync(jobSeekerId);

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

           

            var dto = _mapper.Map<WorkExperienceDto>(request);
            var result = await _profileService.AddWorkExperienceAsync(jobSeekerId, dto);

            return Ok(result);
        }


        [HttpPut("UpdateWorkExperience")]
        public async Task<IActionResult> UpdateWorkExperience([FromBody] UpdateWorkExperienceRequest request)
        {
            var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(jobSeekerIdClaim))
                return Unauthorized();

            Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

          

            var dto = _mapper.Map<WorkExperienceDto>(request);
            var result = await _profileService.UpdateWorkExperienceAsync(jobSeekerId, dto);

            return Ok(result);
        }


        [HttpPatch("PatchWorkExperience")]
        public async Task<IActionResult> PatchWorkExperience([FromBody] PatchWorkExperienceRequest request)
        {
            var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(jobSeekerIdClaim))
                return Unauthorized();

            Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

            

            var dto = _mapper.Map<WorkExperienceDto>(request);
            var result = await _profileService.PatchWorkExperienceAsync(jobSeekerId, dto);

            return Ok(result);
        }

        [HttpGet("ViewWorkexperience")]
        public async Task<IActionResult> ViewWorkExperience()
        {
            var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(jobSeekerIdClaim))
                return Unauthorized();

            Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

           

            var result = await _profileService.GetWorkExperienceByJobSeekerIdAsync(jobSeekerId);

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

               

                bool deleted = await _profileService.DeleteWorkExperienceAsync(id, jobSeekerId);

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

             

            var dto = _mapper.Map<QualificationDto>(request);
            var result = await _profileService.AddQualificationAsync(jobSeekerId, dto);

            return Ok(result);
        }

        [HttpPut("UpdateQualification/{id}")]
        public async Task<IActionResult> UpdateQualification(Guid id, [FromBody] QualificationUpdateRequest request)
        {
            try
            {
                var jobSeekerIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (string.IsNullOrEmpty(jobSeekerIdClaim))
                    return Unauthorized("Job seeker ID not found in token.");

                Guid jobSeekerId = Guid.Parse(jobSeekerIdClaim);

               

                var dto = _mapper.Map<QualificationDto>(request);
                var updated = await _profileService.UpdateQualificationAsync(id, jobSeekerId, dto);

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

               

                var dto = _mapper.Map<QualificationDto>(request);
                var updated = await _profileService.PatchQualificationAsync(id, jobSeekerId, dto);

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

                 

                var result = await _profileService.GetQualificationsByJobSeekerIdAsync(jobSeekerId);

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

                var result = await _profileService.DeleteQualificationAsync(qualificationId, jobSeekerId);
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
    }
}
 

