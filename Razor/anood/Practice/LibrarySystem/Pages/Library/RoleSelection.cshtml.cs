using LibrarySystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace LibrarySystem.Pages.Library
{
    public class RoleSelectionModel : PageModel
    {
        [BindProperty]
        public RoleSelectionViewModel RoleSelection { get; set; }

        public void OnGet()
        {
            RoleSelection = new RoleSelectionViewModel
            {
                Roles = new List<SelectListItem>
            {
                new SelectListItem { Value = "Admin", Text = "Admin" },
                new SelectListItem { Value = "User", Text = "User" }
            }
            };
        }

        public IActionResult OnPost()
        {
            if (RoleSelection.SelectedRole == "Admin")
            {
                return RedirectToPage("/Library/index");  
            }
            else if (RoleSelection.SelectedRole == "User")
            {
                return RedirectToPage("/Library/View");  
            }
            return Page();
        }
    }
}
