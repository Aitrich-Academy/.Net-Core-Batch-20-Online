using JobSeekerPortal.Dtos;
using JobSeekerPortal.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JobSeekerPortal.Controllers
{
    public class JobSeekerController : Controller
    {
        private readonly IUserService _userService;
        private readonly IJobService _jobService;

        public JobSeekerController(IUserService userService, IJobService jobService)
        {
            _userService = userService;
            _jobService = jobService;
        }

        // GET: /JobSeeker/Profile
        public async Task<IActionResult> Profile()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            if (userId == null) return RedirectToAction("Login", "Public");

            var user = await _userService.GetByIdAsync(userId.Value);
            return View(user);
        }

        // POST: /JobSeeker/UpdateProfile
        [HttpPost]
        public async Task<IActionResult> UpdateProfile(UserDto userDto)
        {
            if (!ModelState.IsValid)
                return View("Profile", userDto);

            await _userService.UpdateUserAsync(userDto);
            return RedirectToAction("Profile");
        }

        // GET: /JobSeeker/ListAllJobs
        public async Task<IActionResult> ListAllJobs()
        {
            var jobs = await _jobService.GetAllAsync();
            return View(jobs);
        }

        // GET: /JobSeeker/ApplyJob/{jobId}
        [HttpGet]
        public IActionResult ApplyJob(int jobId)
        {
            ViewBag.JobId = jobId;
            return View();
        }

        // POST: /JobSeeker/ApplyJob
        [HttpPost]
        public IActionResult ApplyJob(int jobId, int userId)
        {
            // Here you would save the application using a repository/service
            // For now, simple placeholder
            TempData["Message"] = $"User {userId} applied to job {jobId}.";
            return RedirectToAction("ListAllJobs");
        }
    }
}
