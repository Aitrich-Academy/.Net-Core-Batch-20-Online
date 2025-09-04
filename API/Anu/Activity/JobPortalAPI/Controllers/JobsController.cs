using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 using JobPortalAPI.Service;
using JobPortalAPI.DTO;
using JobPortalAPI.Interface;
using JobPortalAPI.Models;

namespace JobPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpPost]
        public async Task<IActionResult> AddJob(JobDto jobDto)
        {
            return Ok(await _jobService.AddJobAsync(jobDto));
        }

        [HttpGet]
        public async Task<IActionResult> GetJobs()
        {
            return Ok(await _jobService.GetJobsAsync());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetJobByIdAsync(int id)
        {
            var job = await _jobService.GetJobByIdAsync(id);
            if (job == null) return NotFound();
            return Ok(job);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateJob(int id, [FromBody] JobDto jobDto)
        {
            var updatedJob = await _jobService.UpdateJobAsync(id, jobDto);
            if (updatedJob == null)
                return NotFound(new { message = "Job not found" });

            return Ok(updatedJob);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob(int id)
        {
            var isDeleted = await _jobService.DeleteJobAsync(id);
            if (!isDeleted)
                return NotFound(new { message = "Job not found" });

            return NoContent();
        }
    }
}
