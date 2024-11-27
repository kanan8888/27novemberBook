using Microsoft.AspNetCore.Mvc;
using WebApp27noyabr.Dal;
using WebApp27noyabr.Models;



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
            List<Slider> sliders= db.Sliders.ToList();
            List<BookCategory> bookCategories= db.BookCategorys.ToList();
            List<Book> books= db.Books.ToList();

            ViewBag.Sliders = sliders;
            ViewBag.BookCategories = bookCategories;
            ViewBag.Books = books;

            return View();
        }

    }
}
