using Microsoft.EntityFrameworkCore;
using WebApp27noyabr.Dal;

namespace WebApp27noyabr
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt=>opt.UseSqlServer("server=LAPTOP-769FD5C5;database=Ab107_27November;Trusted_connection=true;Encrypt=false"));

            var app = builder.Build();



            app.UseStaticFiles();


            app.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            app.Run();
        }
    }
}
