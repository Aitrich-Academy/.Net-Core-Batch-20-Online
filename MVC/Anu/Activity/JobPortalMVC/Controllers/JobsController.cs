using Microsoft.AspNetCore.Mvc;
using JobPortalMVC.Interface;
using JobPortalMVC.Dto;


namespace JobPortalMVC.Controllers
{
    public class JobsController : Controller
    {

        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }

         
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(JobDto jobDto)
        {
            if (!ModelState.IsValid) return View(jobDto);
            await _jobService.AddJob(jobDto);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Index(string searchString)
        {
           
            var jobs = await _jobService.GetAllJobsAsync();

            

            return View(jobs);
        }

        public async Task<IActionResult> Details(int id)
        {
            var job = await _jobService.GetJobByIdAsync(id);
            if (job == null) return NotFound();
            return View(job);
        }


        public async Task<IActionResult> Edit(int id)
        {
            var jobDto = await _jobService.GetJobByIdAsync(id);
            if (jobDto == null) return NotFound();

            return View(jobDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, JobDto dto)
        {
            if (!ModelState.IsValid) return View(dto);

            try
            {
                await _jobService.UpdateJobAsync(id, dto);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(dto);
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            var job = await _jobService.GetJobByIdAsync(id);
            if (job == null) return NotFound();
            return View(job);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _jobService.DeleteJobAsync(id);
            return RedirectToAction(nameof(Index));
        }




    }
}

 

 