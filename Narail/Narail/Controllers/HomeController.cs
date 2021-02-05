using Microsoft.AspNetCore.Mvc;


namespace Narail.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
