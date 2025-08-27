using Microsoft.AspNetCore.Mvc;

namespace SimpleAuth.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
