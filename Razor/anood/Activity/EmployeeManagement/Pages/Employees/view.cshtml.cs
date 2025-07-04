using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Model;

namespace EmployeeManagement.Pages.Employees
{
    public class viewModel : PageModel
    {

        private readonly ApplicationDbContext _context;

        public viewModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]

        public Employee myemp { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            myemp = await _context.Employees.FirstOrDefaultAsync(s => s.Id == id);
            if (myemp == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
