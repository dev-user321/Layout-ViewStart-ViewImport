using System.Diagnostics;
using Layout_View.Data;
using Layout_View.Models;
using Layout_View.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Layout_View.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            MainSlider mainSlider = _context.Mains.SingleOrDefault();
            List<RecentWorkDetail> details = _context.Works.ToList();
            HomeVM homeVM = new HomeVM()
            {
                Sliders = sliders,
                MainSlider = mainSlider,
                WorkDetails = details
            };
            return View(homeVM);
        }

        
    }
}
