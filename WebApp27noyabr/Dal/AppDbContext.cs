using Microsoft.EntityFrameworkCore;
using WebApp27noyabr.Models;

namespace WebApp27noyabr.Dal
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        
        public DbSet<Book>Books {get; set;}  
        public DbSet<BookCategory> BookCategorys { get; set;}  
        public DbSet<Slider>Sliders {get; set;}  

    }
}
