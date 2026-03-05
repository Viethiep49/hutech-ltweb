using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using _2380600637_TruongVietHiep_Buoi5.Models;
using System.Linq;

namespace _2380600637_TruongVietHiep_Buoi5.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View(MockData.Books);
        }

        public IActionResult Details(int id)
        {
            var book = MockData.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            var category = MockData.Categories.FirstOrDefault(c => c.Id == book.CategoryId);
            ViewData["CategoryName"] = category?.Name;

            return View(book);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(MockData.Categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                book.Id = MockData.Books.Count > 0 ? MockData.Books.Max(b => b.Id) + 1 : 1;
                MockData.Books.Add(book);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categories = new SelectList(MockData.Categories, "Id", "Name", book.CategoryId);
            return View(book);
        }

        public IActionResult Edit(int id)
        {
            var book = MockData.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            ViewBag.Categories = new SelectList(MockData.Categories, "Id", "Name", book.CategoryId);
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                var existingBook = MockData.Books.FirstOrDefault(b => b.Id == book.Id);
                if (existingBook != null)
                {
                    existingBook.Title = book.Title;
                    existingBook.Author = book.Author;
                    existingBook.CategoryId = book.CategoryId;
                    existingBook.Price = book.Price;
                    existingBook.ImageUrl = book.ImageUrl;
                    existingBook.Description = book.Description;
                }
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categories = new SelectList(MockData.Categories, "Id", "Name", book.CategoryId);
            return View(book);
        }

        public IActionResult Delete(int id)
        {
            var book = MockData.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = MockData.Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                MockData.Books.Remove(book);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
