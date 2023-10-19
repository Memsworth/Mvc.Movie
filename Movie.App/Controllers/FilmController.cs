using Microsoft.AspNetCore.Mvc;

namespace Movie.App.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
