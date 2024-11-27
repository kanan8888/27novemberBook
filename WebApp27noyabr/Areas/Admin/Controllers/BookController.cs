using Microsoft.AspNetCore.Mvc;
using WebApp27noyabr.Dal;
using WebApp27noyabr.Models;

namespace WebApp27noyabr.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        AppDbContext db;

        public BookController(AppDbContext db)
        {
            this.db = db;
        }





        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid) 
            {
                return Index();
            }
            return RedirectToAction(nameof(Index));
        }




    }
}
