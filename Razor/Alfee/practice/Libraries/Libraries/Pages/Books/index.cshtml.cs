using Libraries.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Libraries.Pages.Books
{
    public class indexModel : PageModel
    {
        private readonly BookContext _Context;
        public indexModel(BookContext context)
        {
            _Context = context;
        }
        public IList<Book> mybook { get; set; }
        public async Task OnGetAsync()
        {
            mybook = await _Context.Book.ToListAsync();
        }
    }
}
