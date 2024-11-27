using Microsoft.AspNetCore.Mvc;
using WebApp27noyabr.Dal;


namespace WebApp_26bovember.Areas.AdminPanel.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {

        AppDbContext _db;
        public DashboardController(AppDbContext db)
        {
            _db = db;
        }

 
        public IActionResult Index()
        {
            return View();
        }





    }
}