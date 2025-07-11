using College.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace College.Pages.students
{
    public class CreateModel : PageModel
    {
        private readonly StudentsContext _Context;
        public CreateModel(StudentsContext context)
        {
            _Context = context;
        }
        [BindProperty]
        public Students Students { get; set; }
        public void OnGet()
        {  
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            _Context.Students.Add(Students);
            _Context.SaveChanges();
            return RedirectToPage("index");
        }
    }
}
