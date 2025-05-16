using BookStoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookStoreMVC.Controllers
{
    public class BooksController : Controller
    {
        // Temporary in-memory list of books
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "Atomic Habits", Author = "James Clear", Price = 500 },
            new Book { Id = 2, Title = "Rich Dad Poor Dad", Author = "Robert Kiyosaki", Price = 300 }
        };

        // Action to show the list of books
        public IActionResult Index()
        {
            return View(books);
        }
        // Show the Create form
        public IActionResult Create()
        {
            return View();
        }

        // Handle form submission
        [HttpPost]
        public IActionResult Create(Book book)
        {
            // Auto-increment ID (for demo)
            book.Id = books.Count + 1;
            books.Add(book);

            return RedirectToAction("Index");
        }

        // GET: Books/Edit/1
        public IActionResult Edit(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();

            return View(book);
        }

        // POST: Books/Edit/1
        [HttpPost]
        public IActionResult Edit(Book updatedBook)
        {
            var book = books.FirstOrDefault(b => b.Id == updatedBook.Id);
            if (book == null) return NotFound();

            // Update properties
            book.Title = updatedBook.Title;
            book.Author = updatedBook.Author;
            book.Price = updatedBook.Price;

            return RedirectToAction("Index");
        }
        // GET: Books/Delete/1
        public IActionResult Delete(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();

            return View(book);
        }

        // POST: Books/Delete/1
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null) return NotFound();

            books.Remove(book);
            return RedirectToAction("Index");
        }



    }
}

