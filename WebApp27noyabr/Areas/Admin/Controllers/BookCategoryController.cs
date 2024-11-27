using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp27noyabr.Dal;
using WebApp27noyabr.Models;

namespace WebApp27noyabr.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookCategoryController : Controller
    {

        AppDbContext db;
        public BookCategoryController(AppDbContext db)
        {
            this.db = db;
        }


        public async Task<IActionResult> Index()
        {
            var category = await db.BookCategorys.Include(p=>p.Books).ToListAsync();
            return View(category);
        }

        public IActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookCategory bookCategory)
        {

            db.BookCategorys.Add(bookCategory);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id) 
        {
            if (id == null) return NotFound();
            var bookCategory=db.BookCategorys.FirstOrDefault(p=>p.Id == id);
            if (bookCategory == null) return NotFound();
            db.BookCategorys.Remove(bookCategory);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            var bookCategory = db.BookCategorys.FirstOrDefault(p => p.Id == id);
            if (bookCategory == null) return NotFound();
            return View(bookCategory);
        }
        [HttpPost]
        public IActionResult Update(BookCategory newBookCategory) 
        {
            if (newBookCategory.Id == null) return NotFound();
            var exBookCategory = db.BookCategorys.FirstOrDefault(p => p.Id == newBookCategory.Id);
            if (exBookCategory == null) return NotFound();

            exBookCategory.CategoryName = newBookCategory.CategoryName;
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }




    }
}
