using Layout_View.Models;

namespace Layout_View.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders {  get; set; } 
        public MainSlider MainSlider { get; set; }
        public List<RecentWorkDetail> WorkDetails { get; set; }
    }
}
