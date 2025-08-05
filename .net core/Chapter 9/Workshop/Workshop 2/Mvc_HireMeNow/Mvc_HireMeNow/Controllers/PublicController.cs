using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mvc_HireMeNow.Interfaces;
using Mvc_HireMeNow.Models;

namespace Mvc_HireMeNow.Controllers
{
	public class PublicController : Controller
	{
		private readonly IPublicService _publicService;
		public PublicController(IPublicService publicService)
		{
			_publicService = publicService;
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult JobProviderRegistration(User user)
		{
			try
			{
				_publicService.Register(user);

				return RedirectToAction("Login");




			}
			catch
			{
				return View();
			}
		}
		[HttpGet]
		// GET:  PublicController
		public ActionResult JobProviderRegistration()
		{
			return View();
		}


		public ActionResult Login()
		{
			return View();
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Login(string email, string password)
		{
			try

			{
				var result = _publicService.LoginJobProvider(email, password);
				if (result != null)
				{
					HttpContext.Session.SetString("UserId", result.Id.ToString());
					HttpContext.Session.SetString("CompanyId", result.CompanyId.ToString());
					return RedirectToAction("PostJob","JobProvider");

				}
				else
				{
					ModelState.AddModelError(string.Empty, "Invalid login attempt.");
					return View();
				}

			}
			catch
			{
				return View();
			}
		}
	}
}

		
			

