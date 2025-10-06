using Domain.Service.Applicants.Interface;
using System.Security.Claims;
using JobProviderApi.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobProviderApi.API.JobApplicant
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class ApplicantController : BaseApiController<ApplicantController>
    {
        private readonly IApplicantService _service;

        public ApplicantController(IApplicantService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetApplicants()
        {
            var jobProviderId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var applicants = await _service.GetApplicantsAsync(jobProviderId);
            return Ok(applicants);
        }
    }
}

