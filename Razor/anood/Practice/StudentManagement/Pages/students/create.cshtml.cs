using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManagement.Model;

namespace StudentManagement.Pages.students
{
    public class createModel : PageModel
    {
        private readonly StudentContext _context;
        public createModel(StudentContext context)
        {
            this._context = context;
        }
        [BindProperty]
        public student students { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)

                return Page();
            _context.students.Add(students);
            _context.SaveChanges();

            return RedirectToPage("/students/index");
        }
    }
}

