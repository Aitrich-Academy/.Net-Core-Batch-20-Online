using Domain.Dto;
using Domain.Interface;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WorkApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        // GET: api/Job
        // Everyone with a role can view jobs
        [HttpGet]
        [Authorize(Roles = "JobProvider,JobSeeker,Admin")]
        public async Task<IActionResult> GetAll()
        {
            var jobs = await _jobService.GetAllJobsAsync();
            return Ok(jobs);
        }

        // GET: api/Job/{id}
        [HttpGet("{id}")]
        [Authorize(Roles = "JobProvider,JobSeeker,Admin")]
        public async Task<IActionResult> GetById(int id)
        {
            var job = await _jobService.GetJobByIdAsync(id);
            if (job == null) return NotFound();
            return Ok(job);
        }

        // POST: api/Job
        [HttpPost]
        [Authorize(Roles = "JobProvider")]
        public async Task<IActionResult> Create([FromBody] JobDto jobDto)
        {
            var createdJob = await _jobService.CreateJobAsync(jobDto);
            return CreatedAtAction(nameof(GetById), new { id = createdJob.Id }, createdJob);
        }

        // PUT: api/Job/{id}
        [HttpPut("{id}")]
        [Authorize(Roles = "JobProvider")]
        public async Task<IActionResult> Update(int id, [FromBody] JobDto jobDto)
        {
            var updatedJob = await _jobService.UpdateJobAsync(id, jobDto);
            if (updatedJob == null) return NotFound();
            return Ok(updatedJob);
        }

        // DELETE: api/Job/{id}
        // Admin can delete any job, JobProvider can delete their own jobs
        [HttpDelete("{id}")]
        [Authorize(Roles = "JobProvider,Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            // Optional: if JobProvider, verify ownership
            var userRole = User.FindFirst(ClaimTypes.Role)?.Value;
            if (userRole == "JobProvider")
            {
                // Get the job and verify owner
                var job = await _jobService.GetJobByIdAsync(id);
                if (job == null) return NotFound();

                var userId = int.Parse(User.FindFirst("id").Value);
                if (job.Id != userId)
                    return Forbid("You can only delete your own jobs");
            }

            var success = await _jobService.DeleteJobAsync(id);
            if (!success) return NotFound();
            return NoContent();
        }
    }
}