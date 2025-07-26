using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobPortal.Dto;
using JobPortal.Service;
using Microsoft.EntityFrameworkCore;
using JobPortal.Model;

namespace JobPortal.Pages.MyJob
{
    public class AddUserModel : PageModel
    {
        private readonly UserService _service;
        
        public AddUserModel(UserService service)
        {
            _service = service;
        }
        [BindProperty]
        public UserDto myuser { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrEmpty(myuser.Username) || string.IsNullOrEmpty(myuser.Password))
            {
                ModelState.AddModelError("", "Username and Password are required");
                return Page();
            }

          
            if (!ModelState.IsValid)
                return Page();

            await _service.AddUserAsync(myuser);
            return RedirectToPage("/MyJob/Login");
        }
    }
}
