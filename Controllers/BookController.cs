using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    public class BookController : Controller
    {
        //Hard coded books
        //books/list
        public IActionResult List()
        {
            var books = new List<string>
            {
                "Book 1",
                "Book 2",
                "Book 3"
            };
            return View(books);
        }

        //books/purchase
        [HttpGet]
        public IActionResult Purchase()
        {
            ViewData["Title"] = "Purchase a Book";
            return View();
        }

        //books/purchase
        [HttpPost]
        public IActionResult Purchase(string bookTitle, string address, string email)
        {
            if (string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email))
            {
                ModelState.AddModelError("", "Missing Field(s)");
                return View();
            }
            return RedirectToAction("PurchaseConfirmation", new { book = bookTitle });
        }

        //book/confirmpuchase-XXX
        [HttpGet]
        public IActionResult ConfirmPurchase(string book)
        {
            ViewData["Title"] = "[Purchase Confirmation]";
            ViewData["Book"] = book;
            return View();
        }
    }
}