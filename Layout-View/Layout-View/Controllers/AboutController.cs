﻿using Microsoft.AspNetCore.Mvc;

namespace Layout_View.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
