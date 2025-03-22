using Layout_View.Models;
using Microsoft.EntityFrameworkCore;

namespace Layout_View.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<MainSlider> Mains { get; set; }
        public DbSet<RecentWorkDetail> Works { get; set; }
    }
}
