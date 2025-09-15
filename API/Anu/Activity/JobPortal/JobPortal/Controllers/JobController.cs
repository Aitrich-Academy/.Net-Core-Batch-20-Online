using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Domain.Dto;
using Domain.Interface;
using Domain.Service;
using Microsoft.AspNetCore.Authorization;
using Domain.Enum;

namespace JobPortal.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        public readonly IJobService _jobservice;
        public JobController(IJobService jobservice)
        {
            _jobservice = jobservice;
        }

        [HttpGet]
        [Route("GetAllJobs")]
        [Authorize(Roles = "ADMIN, JOBSEEKER, JOBPROVIDER")]
        public async Task<IActionResult> GetAllJobs()
        {
            var Alljobs = await _jobservice.GetAllJobsAsync();
            return Ok(Alljobs);
        }

        [HttpGet]
        [Route("GetJobById")]
        [Authorize(Roles = "JOBPROVIDER")]
        public async Task<IActionResult> GetJobById(int id)
        {
            var jobByid = await _jobservice.GetJobByIdAsync(id);
            if (jobByid == null) return NotFound();
            return Ok(jobByid);
        }

        [HttpPost]
        [Route("AddJobs")]
        [Authorize(Roles = "JOBPROVIDER")]
        public async Task<IActionResult> AddJob([FromBody] JobDto jobdto)
        {
            var addjob = await _jobservice.AddJobAsync(jobdto);
            
            return Ok(addjob);
        }

        [HttpPut]
        [Route("EditJobs")]
        [Authorize(Roles = "JOBPROVIDER")]
        public async Task<IActionResult> UpdateJob(int id, JobDto jobdto)
        {
            if (id != jobdto.Id) return NotFound();
            var updatejob = await _jobservice.UpdateJobAsync(jobdto);
            return Ok(updatejob);
        }

        [HttpDelete]
        [Route("DeleteJobs")]
        [Authorize(Roles = "ADMIN, JOBPROVIDER")]
        public async Task<IActionResult> DeleteJob(int id)
        {
            var deletejob = await _jobservice.DeleteJobAsync(id);
            if (!deletejob) return NotFound();
            return NoContent();
        }
    }
}

