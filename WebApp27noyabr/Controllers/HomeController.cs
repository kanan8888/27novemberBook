using Microsoft.AspNetCore.Mvc;
using WebApp27noyabr.Dal;



namespace WebApp27noyabr.Controllers
{
    public class HomeController : Controller
    {
       AppDbContext db;

        public HomeController(AppDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            List<>

            return View();
        }

    }
}
