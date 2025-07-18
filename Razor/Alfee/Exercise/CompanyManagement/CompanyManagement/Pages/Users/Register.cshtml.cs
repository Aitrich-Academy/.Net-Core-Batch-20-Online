using CompanyManagement.Dto;
using CompanyManagement.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CompanyManagement.Pages.Users
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService _userService;

        public RegisterModel(IUserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        public UserDto UserDto { get; set; } = new();

        public string? Message { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            var result = await _userService.RegisterUserAsync(UserDto);

            if (!result)
            {
                Message = "Username already exists.";
                return Page();
            }

            // Redirect to login page after successful registration
            return RedirectToPage("/Users/Login");
        }
    }
}
