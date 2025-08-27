using JobPortalSystem.Dto;
using JobPortalSystem.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalSystem.Controllers
{
    public class JobsController : Controller
    {
        private readonly IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }
        // step 1 : Jobs (List all jobs)
        public async Task<IActionResult> Index()
        {
            var jobs = await _jobService.GetAllJobs();
            return View(jobs);
        }

        // step 2: Jobs/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var job = await _jobService.GetJobById(id);
            if (job == null) return NotFound();
            return View(job);
        }

        // step 3 : Jobs/Create (Show job creation form)
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
            // return ("Index", "Jobs");
        }

        // step 4 : Jobs/Edit (Show job edit form)
        public async Task<IActionResult> Edit(int id)
        {
            var job = await _jobService.GetJobById(id);
            if (job == null) return NotFound();
            return View(job);
        }

        // step 5 : Jobs/Edit (Submit job edit form)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, JobDto jobDto)
        {
            if (id != jobDto.Id) return BadRequest();
            if (!ModelState.IsValid) return View(jobDto);
            await _jobService.UpdateJob(jobDto);
            return RedirectToAction(nameof(Index));
        }

        // step 6 : Jobs/Delete (Show delete page)
        public async Task<IActionResult> Delete(int id)
        {
            var job = await _jobService.GetJobById(id);
            if (job == null) return NotFound();
            return View(job);
        }

        // step 7 : Jobs/Delete (Confirm delete action)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _jobService.DeleteJob(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
