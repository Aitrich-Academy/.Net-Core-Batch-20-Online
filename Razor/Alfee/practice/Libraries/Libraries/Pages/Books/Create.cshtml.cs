using Libraries.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Libraries.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly BookContext _Context;

        public CreateModel(BookContext context)
        {
            _Context = context;
        }
        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            _Context.Book.Add(Book);
            _Context.SaveChanges();
            return RedirectToPage("index");
        }
    }
}
