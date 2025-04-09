using System.Diagnostics;
using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    public class StoreController : Controller
    {
        [HttpPost]
        public IActionResult Purchase(string bookTitle, string address, string email)
        {
            if (string.IsNullOrEmpty(address) || string.IsNullOrEmpty(email))
            {
                ModelState.AddModelError("", "Missing Field(s)");
                ViewData["Title"] = "Purchase a Book - Error";
                return View("~/Views/Book/Store.cshtml");
            }
            return RedirectToAction("Success", new { book = bookTitle });
        }

        [HttpGet]
        public IActionResult Success(string book)
        {
            ViewData["Title"] = "Purchase Confirmation";
            ViewData["Book"] = book;
            return View();
        }

        [HttpGet]
        public IActionResult Shipping()
        {
            ViewData["Title"] = "Shipping Information";
            ViewData["Policy"] = "We wont actually ship sorry </3";
            ViewData["Cost"] = "But it is free!";
            return View();
        }
    }
}