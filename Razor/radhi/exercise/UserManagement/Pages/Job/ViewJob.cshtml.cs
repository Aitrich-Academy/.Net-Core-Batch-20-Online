using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserManagement.Interface;
using UserManagement.Models;

namespace UserManagement.Pages.Job
{
    public class ViewAppliedModel : PageModel
    {
        private readonly IAppliedService _appliedService;
        private readonly IUserService _userService;

        public ViewAppliedModel(IAppliedService appliedService, IUserService userService)
        {
            _appliedService = appliedService;
            _userService = userService;
        }

        public List<Models.Job> AppliedJobs { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var username = HttpContext.Session.GetString("User");
            if (string.IsNullOrEmpty(username))
                return RedirectToPage("/Log/Login");

            var user = await _userService.GetUserByUsernameAsync(username);
            if (user == null)
                return RedirectToPage("/Log/Login");

            AppliedJobs = await _appliedService.GetAppliedJobsByUserIdAsync(user.UserId);
            return Page();
        }
    }
}

