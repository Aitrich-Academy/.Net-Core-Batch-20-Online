using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserManagement.Interface;
using UserManagement.Models;

namespace UserManagement.Pages.Job
{
    public class IndexModel : PageModel
    {
        private readonly IJobService _jobService;
        private readonly IAppliedService _appliedService;
        private readonly IUserService _userService;

        public List<Models.Job> JobPosts { get; set; }

        public IndexModel(IJobService jobService, IAppliedService appliedService, IUserService userService)
        {
            _jobService = jobService;
            _appliedService = appliedService;
            _userService = userService;
        }

        public async Task OnGetAsync()
        {
            JobPosts = await _jobService.GetAllJobsAsync();
        }

        public async Task<IActionResult> OnPostApplyAsync(int jobId)
        {
            var username = HttpContext.Session.GetString("User");

            if (string.IsNullOrEmpty(username))
                return RedirectToPage("/Log/Login");

            var user = await _userService.GetUserByUsernameAsync(username);
            if (user == null)
            {
                ModelState.AddModelError("", "User not found.");
                return Page();
            }

            try
            {
                await _appliedService.ApplyForJobAsync(user.UserId, jobId);
                TempData["Message"] = "Successfully applied!";
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            JobPosts = await _jobService.GetAllJobsAsync();
            return Page();
        }
    }
}
