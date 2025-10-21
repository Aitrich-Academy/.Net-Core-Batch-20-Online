using System.Security.Claims;
using AutoMapper;
using Domain.Service.Authuser;
using Domain.Service.Authuser.Interfaces;
using Domain.Service.JobSeeker;
using Domain.Service.JobSeeker.DTOs;
using Domain.Service.JobSeeker.Interfaces;
using Domain.Service.Login.Interfaces;
using Job_Portal.API.JobSeeker.RequestObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Job_Portal.API.JobSeeker
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobSeekerController : ControllerBase
    {
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

    }
}
