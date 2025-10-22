using AutoMapper;
using Domain.Service.JobProvider;
using Domain.Service.JobProvider.Dto;
using Domain.Service.JobProvider.Interfaces;
using Job_Portal.API.JobProvider.Request_Object;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Job_Portal.API.JobProvider
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobProviderController : ControllerBase
    {
        private readonly IJobProviderService _service;
        private readonly IMapper _mapper;

        public JobProviderController(IJobProviderService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        // -------------------------
        // JOB SEEKER ENDPOINTS
        // -------------------------

        [HttpGet("jobseekers")]
        public async Task<IActionResult> GetJobSeekers()
        {
            var jobSeekers = await _service.GetJobSeekersAsync();
            return Ok(jobSeekers);
        }

        [HttpGet("jobseekers/{id}")]
        public async Task<IActionResult> GetJobSeekerById(Guid id)
        {
            var jobSeeker = await _service.GetJobSeekerByIdAsync(id);
            if (jobSeeker == null)
                return NotFound();

            return Ok(jobSeeker);
        }

        [HttpGet("jobseekers/title/{title}")]
        public async Task<IActionResult> GetJobSeekersByTitle(string title)
        {
            var jobSeekers = await _service.GetJobSeekersByTitleAsync(title);
            return Ok(jobSeekers);
        }

        // -------------------------
        // JOB POST ENDPOINTS
        // -------------------------

        [HttpPost("jobs")]
        public async Task<IActionResult> CreateJobPost([FromBody] CreateJobPostRequest request)
        {
            var jobPostDto = _mapper.Map<JobPostDto>(request);
            var jobId = await _service.CreateJobPostAsync(jobPostDto);
            return Ok(new { jobId, message = "Job created successfully" });
        }

        [HttpGet("jobs/{id}")]
        public async Task<IActionResult> GetJobById(Guid id)
        {
            var job = await _service.GetJobByIdAsync(id);
            if (job == null)
                return NotFound();

            return Ok(job);
        }

        [HttpPut("jobs/{id}")]
        public async Task<IActionResult> UpdateJobById(Guid id, [FromBody] UpdateJobPostRequest request)
        {
            var updatedJobDto = _mapper.Map<JobPostDto>(request);
            var result = await _service.UpdateJobByIdAsync(id, updatedJobDto);
            if (!result) return NotFound("Job not found");

            return Ok(new { message = "Job updated successfully" });
        }

        [HttpPatch("jobs/{id}")]
        public async Task<IActionResult> PatchJobById(Guid id, [FromBody] PatchJobPostRequest request)
        {
            var result = await _service.PatchJobByIdAsync(id, request.Salary);
            if (!result) return NotFound(new { message = "Job not found" });
            return Ok(new { message = "Job updated successfully" });
        }

        [HttpDelete("jobs/{id}")]
        public async Task<IActionResult> DeleteJobById(Guid id)
        {
            var result = await _service.DeleteJobByIdAsync(id);
            if (!result)
                return NotFound();

            return Ok(new { message = "Job deleted successfully" });
        }

        [HttpGet("jobs")]
        public async Task<IActionResult> GetAllJobs()
        {
            var jobs = await _service.GetAllJobsAsync();
            return Ok(jobs);
        }

        [HttpGet("applications/count")]
        public async Task<IActionResult> GetApplicationCount()
        {
            var count = await _service.GetApplicationCountAsync();
            return Ok(new { totalApplications = count });
        }
                               
    }
}
