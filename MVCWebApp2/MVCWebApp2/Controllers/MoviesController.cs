using Microsoft.AspNetCore.Mvc;

namespace MVCWebApp2.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Start()
        {
            return View();
        }
    }
}
