using JobApi.Interface;
using JobPortalAPI.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobApi.Controllers
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

        [HttpGet]
        public async Task<IActionResult> GetJobs()
        {
            // Get the logged-in user's ID from session
            var userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
            {
                // If no user is logged in, return Unauthorized
                return Unauthorized("You must be logged in to view jobs.");
            }

            // If user is logged in, fetch jobs
            var jobs = await _jobService.GetJobsAsync();
            return Ok(jobs);
        }

        [HttpPost]
        public async Task<IActionResult> AddJob([FromBody] JobDTO jobDto)
        {
            // Get the logged-in userId from session
            var userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return Unauthorized("You must be logged in to add a job");

            var result = await _jobService.AddJobAsync(jobDto, userId.Value);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJob(int id, [FromBody] JobDTO jobDto)
        {
            // Get user ID from session
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null)
                return Unauthorized(new { message = "You must be logged in to update a job" });

            var updatedJob = await _jobService.UpdateJobAsync(id, jobDto, userId.Value);
            if (updatedJob == null)
                return NotFound(new { message = "Job not found or you are not authorized" });

            return Ok(updatedJob);
        }


        // Delete a job
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob(int id)
        {
            // 1. Get the logged-in user's ID from session
            var userId = HttpContext.Session.GetInt32("UserId");

            // 2. If no user is logged in, return Unauthorized
            if (userId == null)
            {
                return Unauthorized("You must be logged in to delete a job.");
            }

            // 3. Attempt to delete the job via the service
            // The service ensures only the owner can delete their job
            var isDeleted = await _jobService.DeleteJobAsync(id, userId.Value);

            // 4. If deletion failed, return NotFound
            if (!isDeleted)
            {
                return NotFound(new { message = "Job not found or you don't have permission to delete it." });
            }

            // 5. If deletion succeeded, return NoContent
            return NoContent();
        }

    }
}
