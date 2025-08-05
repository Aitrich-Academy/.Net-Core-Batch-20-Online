using Microsoft.AspNetCore.Mvc;

namespace Sample.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
