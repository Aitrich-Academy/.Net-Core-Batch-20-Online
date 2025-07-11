using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEmployee.Model;

namespace RazorEmployee.Pages.Employees
{
    public class createModel : PageModel
    {
        private readonly ApplicationDbContext _Context;
        public createModel(ApplicationDbContext context)
        {
            _Context = context;
        }
        [BindProperty]
        public Employee Employee { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            _Context.Employees.Add(Employee);
            _Context.SaveChanges();
            return RedirectToPage("index");

        }

    }
}
