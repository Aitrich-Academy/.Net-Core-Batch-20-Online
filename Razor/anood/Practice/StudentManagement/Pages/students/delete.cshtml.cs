using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Model;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StudentManagement.Pages.students
{
    public class deleteModel : PageModel
    {
        private readonly StudentContext _context;

        public deleteModel(StudentContext context)
        {
            _context = context;
        }

        [BindProperty]
        public student mystudents { get; set; }


        public async Task<IActionResult> OnGetAsync(int id)
        {
            mystudents = await _context.students.FirstOrDefaultAsync(s => s.studentId == id);
            if (mystudents == null)
            {
                return NotFound();
            }
            return Page();
        }



        public async Task<IActionResult> OnPostAsync(int id)
        {
            mystudents = await _context.students.FirstOrDefaultAsync(s => s.studentId == id);

            if (mystudents == null)
            {
                return NotFound();
            }

            _context.students.Remove(mystudents);
            await _context.SaveChangesAsync();

            return RedirectToPage("index");
        }







    }
}



 
 