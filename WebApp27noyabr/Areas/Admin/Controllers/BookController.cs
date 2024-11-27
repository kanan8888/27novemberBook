using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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





        public async Task<IActionResult> Index()
        {
            var books = await db.Books.Include(p=>p.BookCategory).ToListAsync();
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {

            db.Books.Add(book);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            if (id == null) return NotFound();
            var book = db.Books.FirstOrDefault(p => p.Id == id);
            if (book == null) return NotFound();
            db.Books.Remove(book);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Update(int id) 
        {
            if (id == null) return NotFound();
            var book = db.Books.FirstOrDefault(p => p.Id == id);
            if (book == null) return NotFound();
            return View(book);
        }
        [HttpPost]
        public IActionResult Update(Book newBook) 
        {
            if (newBook.Id == null) return NotFound();
            var exBook = db.Books.FirstOrDefault(p => p.Id == newBook.Id);
            if (exBook == null) return NotFound();
            exBook.Name = newBook.Name;
            exBook.AuthorName = newBook.AuthorName;
            exBook.Price = newBook.Price;
            exBook.BookCategoryId = newBook.BookCategoryId;
            exBook.ImageUrl = newBook.ImageUrl;
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }




    }
}
