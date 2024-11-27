using Microsoft.AspNetCore.Mvc;
using WebApp27noyabr.Dal;

namespace WebApp27noyabr.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        AppDbContext db;
        public SliderController(AppDbContext db)
        {
            this.db = db;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
