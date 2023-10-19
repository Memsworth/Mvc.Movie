using Microsoft.AspNetCore.Mvc;

namespace Movie.App.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
