using College.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace College.Pages.students
{
    public class DeleteModel : PageModel
    {
        private readonly StudentsContext _Context;
        public DeleteModel(StudentsContext context)
        {
            _Context = context;
        }
        [BindProperty]
        public Students Students { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Students = await _Context.Students.FindAsync(id);

            if (Students == null)
            {
                return NotFound();
            }

            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var student = await _Context.Students.FindAsync(Students.Id);

            if (student != null)
            {
                _Context.Students.Remove(student);
                await _Context.SaveChangesAsync();
            }

            return RedirectToPage("index"); // or your main list page
        }
    }
}
