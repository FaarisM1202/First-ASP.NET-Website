using Microsoft.AspNetCore.Mvc;

namespace AlmostEmptyStarter.Controllers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            /* This will set the title either in the controller 
             * or the index.*/
            ViewData["Title"] = "Home Page";
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
