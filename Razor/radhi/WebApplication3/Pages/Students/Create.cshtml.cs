using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Model;

namespace WebApplication3.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly StudentDbContext _context;
        public CreateModel(StudentDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Student Students { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)

                return Page();
            _context.Students.Add(Students);
            _context.SaveChanges();
            return RedirectToPage("Index");

        }
    }
}
