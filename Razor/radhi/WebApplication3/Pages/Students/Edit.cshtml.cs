using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Model;
namespace WebApplication3.Pages.Students
{

    public class EditModel : PageModel
    {
        private readonly StudentDbContext _context;

        public EditModel(StudentDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Student Students { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Students = await _context.Students.FindAsync(id);

            if (Students == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Students).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Students.Any(e => e.Id == Students.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("Index");
        }
    }
}