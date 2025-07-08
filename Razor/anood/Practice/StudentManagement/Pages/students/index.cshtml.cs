using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace StudentManagement.Pages.students
{
    public class indexModel : PageModel
    {
        private readonly StudentContext _contex;
        public indexModel(StudentContext contex)
        {
            _contex = contex;
        }
        public IList<student> StudentList { get; set; }

        public async Task OnGetAsync()
        {
            StudentList = await _contex.students.ToListAsync();
        }
    }
}
