using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Model;

namespace WebApplication3.Pages.Students
{
    public class ViewModel : PageModel
    {
        private readonly StudentDbContext _context;
        public ViewModel(StudentDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Student Students { get; set; }
        public async Task OnGetAsync(int id)
        {
            Students = await _context.Students.FindAsync(id);
        }
    }
}
