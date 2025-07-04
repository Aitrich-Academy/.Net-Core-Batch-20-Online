using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmployeeManagement.Model;

namespace EmployeeManagement.Pages.Employees
{
    public class createModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Employee Employee { get; set; }

        public createModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Employees.Add(Employee);
            _context.SaveChanges();
            return RedirectToPage("index");
        }
    }
}

