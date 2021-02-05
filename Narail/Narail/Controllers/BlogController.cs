using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Narail.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }

        public PartialViewResult BlogDetail()
        {
            return PartialView("BlogDetailContent");

        }
    }
}
