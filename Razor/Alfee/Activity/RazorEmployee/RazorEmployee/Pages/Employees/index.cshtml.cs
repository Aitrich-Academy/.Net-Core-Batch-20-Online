using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorEmployee.Model;

namespace RazorEmployee.Pages.Employees
{
    public class indexModel : PageModel
    {
        private readonly ApplicationDbContext _Context;
        public indexModel(ApplicationDbContext context)
        {
            _Context = context;
        }
        public IList<Employee> EmployeeList { get; set; } = new List<Employee>();

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }


        public async Task OnGetAsync()
        {
            var query = _Context.Employees.AsQueryable();

            if (!string.IsNullOrWhiteSpace(SearchTerm))
            {
                query = query.Where(e => e.Name.Contains(SearchTerm) || e.Position.Contains(SearchTerm));
            }
            EmployeeList = await query.ToListAsync();
        }
    }
}
