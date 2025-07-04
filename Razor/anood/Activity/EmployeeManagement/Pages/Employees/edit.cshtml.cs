using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Model;


namespace EmployeeManagement.Pages.Employees
{
    public class editModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public editModel(ApplicationDbContext context)
        {
            this._context = context;
        }

        [BindProperty]

        public Employee  myemp { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            myemp = await _context.Employees.FirstOrDefaultAsync(s => s.Id == id);
            if (myemp == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Attach(myemp).State = EntityState.Modified;

            var existingStudent = _context.Employees.FirstOrDefault(Employee => Employee.Id  == myemp.Id);
            if (existingStudent == null)
                return NotFound();



            existingStudent.Name = myemp.Name;
            existingStudent.Position = myemp.Position;
            existingStudent.Salary = myemp.Salary;
            existingStudent.Department = myemp.Department;


            _context.SaveChanges();

            return RedirectToPage("/Employees/index");
        }
    }
}

