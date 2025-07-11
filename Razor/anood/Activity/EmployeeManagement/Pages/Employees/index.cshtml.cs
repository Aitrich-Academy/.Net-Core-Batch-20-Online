using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Model;
using System.Threading.Tasks;

namespace EmployeeManagement.Pages.Employees
{
    public class indexModel : PageModel
    {
        private readonly ApplicationDbContext  _context;

        public indexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IList<Employee> empList { get; set; }
        public async Task OnGet()
        {
            empList = await _context.Employees.ToArrayAsync();
        }
    }
}
