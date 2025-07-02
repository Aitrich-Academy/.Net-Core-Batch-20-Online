using College.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace College.Pages.students
{
    public class EditModel : PageModel
    {
        private readonly StudentsContext _Context;
        public EditModel(StudentsContext context)
        {
            _Context = context;
        }
        [BindProperty]
        public Students Students { get; set; }
    
       
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var existingStudents = _Context.Students.FirstOrDefault(s => s.Id == Students.Id);
            if (existingStudents == null)
                return NotFound();
            existingStudents.Name = Students.Name;
            existingStudents.Age = Students.Age;
            existingStudents.Course = Students.Course;

            _Context.SaveChanges();
            return RedirectToPage("/students/index");
        }

        public IActionResult OnGet(int id)
        {
            Students = _Context.Students.FirstOrDefault(s => s.Id == id);

            if (Students == null)
                return NotFound();        
            return Page();
        }
    }
}
