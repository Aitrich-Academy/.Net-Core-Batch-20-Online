using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Domain.Dto;
using Domain.Interface;
using Domain.Service;


namespace JobCurd_ClassLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        public readonly IJobService _jobservice;
        public JobController (IJobService jobservice)
        {
            _jobservice = jobservice;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllJobs()
        {
            var Alljobs=await _jobservice.GetAllJobsAsync();
            return Ok(Alljobs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetJobById(int id)
        {
            var jobByid=await _jobservice .GetJobByIdAsync (id);
            if (jobByid == null) return NotFound();
            return Ok(jobByid);
        }

        [HttpPost]
        public async Task<IActionResult> AddJob([FromBody]  JobDto jobdto)
        {
            var addjob=await _jobservice.AddJobAsync (jobdto);
            //return CreatedAtAction(nameof(GetAllJobs), new {id = jobdto.Id}, addjob);
            return Ok(addjob);
        }

        [HttpPut ("{id}")]
        public async Task<IActionResult> UpdateJob(int id ,JobDto jobdto)
        {
            if(id!=jobdto.Id) return NotFound ();
            var updatejob = await _jobservice.UpdateJobAsync( jobdto);
            return Ok(updatejob);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJob(int id)
        {
            var deletejob= await _jobservice.DeleteJobAsync(id);
            if(!deletejob) return NotFound();
            return NoContent ();
        }
    }
}
