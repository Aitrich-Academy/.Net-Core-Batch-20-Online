using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Model;
using Microsoft.EntityFrameworkCore;
namespace WebApplication3.Pages.Students

    {
        public class DeleteModel : PageModel
        {
            private readonly StudentDbContext _context;

            public DeleteModel(StudentDbContext context)
            {
                _context = context;
            }

            [BindProperty]
            public Student Student { get; set; }

            public async Task<IActionResult> OnGetAsync(int? id)
            {
                if (id == null)
                    return NotFound();

                Student = await _context.Students.FirstOrDefaultAsync(m => m.Id == id);

                if (Student == null)
                    return NotFound();

                return Page();
            }

            public async Task<IActionResult> OnPostAsync(int? id)
            {
                if (id == null)
                    return NotFound();

                Student = await _context.Students.FindAsync(id);

                if (Student != null)
                {
                    _context.Students.Remove(Student);
                    await _context.SaveChangesAsync();
                }

                return RedirectToPage("./Index");
            }
        }
    }


   
  

