using AutoMapper;
using Mvc_HireMeNow.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Mvc_HireMeNow.Dtos;
using Mvc_HireMeNow.Interfaces;
using Mvc_HireMeNow.Models;
using System.Threading.Tasks.Dataflow;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using Mvc_HireMeNow.Services;
using System.ComponentModel.Design;

namespace Mvc_HireMeNow.Controllers
{
	public class JobProviderController : Controller
	{
		IMapper _mapper;
		IJobRepository _jobRepository;
		IJobService _jobService;
		IUserRepository _userRepository;
	
		public JobProviderController(IMapper mapper, IJobRepository jobRepository,IUserRepository userRepository,IJobService jobService)
		{
			_mapper = mapper;
			_jobRepository = jobRepository;
			_userRepository = userRepository;
			
			_jobService = jobService;
		

        }

		public IActionResult Index()
		{
			return View();
		}
		public ActionResult PostJob()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult PostJob(JobDto jobDto)
		{
			var uid = HttpContext.Session.GetString("UserId");


			
			User user = _userRepository.getById(new Guid(uid));
			jobDto.CompanyId = (Guid)user.CompanyId;
			var job = _mapper.Map<Job>(jobDto);
			bool result=_jobRepository.Create(job);
		
			
				TempData["Message"] = "Successfully posted Job";
			return RedirectToAction("AllJobs");


		}


		public IActionResult AllJobs()
		{
			var uid = HttpContext.Session.GetString("UserId");



			User user = _userRepository.getById(new Guid(uid));
			Guid cmpId = (Guid)user.CompanyId;
			List<Job> jobs = _jobService.GetJobsposted(cmpId);

			return View(jobs);
		}



	}
}
