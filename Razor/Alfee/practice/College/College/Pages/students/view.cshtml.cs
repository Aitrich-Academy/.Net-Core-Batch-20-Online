using System.Threading.Tasks;
using College.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace College.Pages.students
{
    public class viewModel : PageModel
    {
        private readonly StudentsContext _Context;
        public viewModel(StudentsContext context)
        {
            _Context = context;
        }
        [BindProperty]
        public Students Students { get; set; }
        public async Task<IActionResult> OnGet(int id)
        {
            Students = _Context.Students.FirstOrDefault(Students => Students.Id == id);
            if (Students == null)
                return NotFound();
            return Page();
        }
    }
}
