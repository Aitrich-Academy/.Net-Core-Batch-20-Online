using College.Modal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace College.Pages.students
{
    public class indexModel : PageModel
    {
        private readonly StudentsContext _Context;
        public indexModel(StudentsContext context)
        {
            _Context = context;
        }
        public IList<Students> StudentList { get; set; }

        public async Task OnGetAsync()
        {
            StudentList = await _Context.Students.ToListAsync();
        }
       
    }
}
