﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Narail.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Service()
        {
            return View();
        }
    }
}
