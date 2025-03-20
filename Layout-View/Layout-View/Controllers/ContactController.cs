using Microsoft.AspNetCore.Mvc;

namespace Layout_View.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
