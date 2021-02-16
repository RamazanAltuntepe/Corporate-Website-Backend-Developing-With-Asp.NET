using Microsoft.AspNetCore.Mvc;


namespace Narail.Controllers
{
    public class BlogController : Controller
    {
        

        public IActionResult Blog()
        {
           
            return View();
        }

        public IActionResult BlogDetailContent()
        {
            return PartialView("BlogDetailContent");
        }
       
    }
}
