using Domain.Service.Profile.Dto;
using Domain.Service.Profile.Interface;
using System.Security.Claims;
using JobProviderApi.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobProviderApi.API.Profile
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProfileController :  BaseApiController<ProfileController>
    {
        private readonly IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProfile()
        {
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var profile = await _profileService.GetProfileAsync(userId);
            if (profile == null) return NotFound();
            return Ok(profile);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProfile(JobProviderProfileDto dto)
        {
            var updated = await _profileService.UpdateProfileAsync(dto);
            if (updated == null) return NotFound();
            return Ok(updated);
        }
    }
}

