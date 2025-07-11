using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JobManagement.Dto;
using JobManagement.Service;
using JobManagement.Model;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace JobManagement.Pages.Job
{
    public class viewModel : PageModel
    {

        private readonly JobService _service;
        public viewModel(JobService service)
        {
            _service = service;
        }

        [BindProperty]
        public Jobs JobPost { get; set; }



        public async Task<IActionResult> OnGetAsync(int id)
        {
            var jobDto = await _service.GetJobByIdAsync(id);
            if (jobDto == null)
            {
                return NotFound();
            }

            JobPost = jobDto;
            return Page();
        }


        //public async Task<IActionResult> OnGetAsync(int id)
        //{
        //    mybook = await _context.books.FirstOrDefaultAsync(s => s.BookId == id);
        //    if (mybook == null)
        //    {
        //        return NotFound();
        //    }
        //    return Page();
        //}



    }
}
