using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManagement.Model;
using Microsoft.EntityFrameworkCore;


namespace StudentManagement.Pages.students
{
    public class viewModel : PageModel
    {
        private readonly StudentContext _context;
        public viewModel(StudentContext context)
        {
            this._context = context;
        }

        [BindProperty]

        public student students { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
        {
            students = await _context.students.FirstOrDefaultAsync(s => s.studentId == id);
            if (students == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}



// <a asp-page="./Edit" asp-route-id="@Model.students.studentId" class="btn btn-sm btn-outline-secondary">
//     Edit
// </a>
// <a asp-page="./delete" asp-route-id="@Model.students.studentId" class="btn btn-sm btn-outline-secondary">
//     Delete
// </a>