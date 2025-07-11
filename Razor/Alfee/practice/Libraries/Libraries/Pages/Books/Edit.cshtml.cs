using Libraries.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Libraries.Pages.Books
{
    public class EditModel : PageModel
    {
        private readonly BookContext _Context;
        public EditModel(BookContext context)
        {
            _Context = context;
        }
        [BindProperty]
        public Book Book { get; set; }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();
            var existingBooks = _Context.Book.FirstOrDefault(b => b.Id == Book.Id);
            if (existingBooks == null)
                return NotFound();
            existingBooks.Title = Book.Title;
            existingBooks.Author = Book.Author;
            existingBooks.Price = Book.Price;
            existingBooks.DateofPublish = Book.DateofPublish;

            _Context.SaveChanges();
            return RedirectToPage("/Books/index");
        }

        public IActionResult OnGet(int id)
        {
            Book = _Context.Book.FirstOrDefault(b => b.Id == id);

            if (Book == null)
                return NotFound();
            return Page();
        }
       
    }
}
