using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    [Route("book")]
    public class BookController : Controller
    {
        [HttpGet("add")]
        public IActionResult addBook()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult AddBook(BookModel book)
        {
            if (Model.IsValid)
            {
                return RedirectToAction("Success");
            }
        }
        [HttpGet("success")]
        public IActionResult Success()
        {
            return View();
        }
    }
}