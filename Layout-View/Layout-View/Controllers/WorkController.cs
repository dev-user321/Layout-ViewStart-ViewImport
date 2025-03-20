using Microsoft.AspNetCore.Mvc;

namespace Layout_View.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
