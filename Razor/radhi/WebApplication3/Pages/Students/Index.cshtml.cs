using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Model;

namespace WebApplication3.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentDbContext _context;
         public IndexModel(StudentDbContext context)
        {
            _context = context;
        }
        public IList<Student> StudentList { get; set; }
        public async Task OnGetAsync()
        {
            StudentList=await _context.Students.ToListAsync();

        }
     
      
    }
}
