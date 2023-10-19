using Microsoft.AspNetCore.Mvc;

namespace Movie.App.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
