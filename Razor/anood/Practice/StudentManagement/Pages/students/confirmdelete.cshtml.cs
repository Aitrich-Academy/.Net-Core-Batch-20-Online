using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Model;

namespace StudentManagement.Pages.students
{
    public class confirmdeleteModel : PageModel
    {
        private readonly StudentContext _context;

        public confirmdeleteModel(StudentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public student mystudents { get; set; }
 
        public IActionResult OnPost()
        {
            // Create a stub entity with the submitted ID
            var student = new student { studentId = mystudents.studentId };

            _context.students.Attach(student);
            _context.students.Remove(student);

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                // Log the error (ex)
                ModelState.AddModelError("", "Unable to delete. Try again, and if the problem persists see your system administrator.");
                return Page();
            }

            return RedirectToPage("index");
        }

    }
}
