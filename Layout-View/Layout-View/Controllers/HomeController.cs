using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Layout_View.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        
    }
}
