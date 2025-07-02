using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorEmployee.Model;

namespace RazorEmployeeManagement.Pages.Employees
{
    public class deleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public deleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Employee = await _context.Employees.FindAsync(id);

            if (Employee == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var employee = await _context.Employees.FindAsync(Employee.Id);

            if (employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return RedirectToPage("index");
        }
    }
}

