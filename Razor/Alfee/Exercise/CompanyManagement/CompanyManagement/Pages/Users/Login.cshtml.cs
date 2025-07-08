using CompanyManagement.Dto;
using CompanyManagement.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CompanyManagement.Pages.Users
{
    public class LoginModel : PageModel
    {
        private readonly IUserService _userService;

        public LoginModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public UserDto UserDto { get; set; } = new(); // ? Ensure initialization

        public string? ErrorMessage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var user = await _userService.LoginUserAsync(UserDto);

            if (user == null)
            {
                ErrorMessage = "Invalid username or password";
                return Page();
            }

            HttpContext.Session.SetInt32("UserId", user.Id);
            HttpContext.Session.SetString("UserName", user.Username);

            return RedirectToPage("/Members/Index");
        }
    }
}
