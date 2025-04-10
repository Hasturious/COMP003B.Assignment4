using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    public class StoreController : Controller
    {
        [HttpGet]
        public IActionResult Order()
        {
            ViewData["Title"] = "Order Eldritch Tomes";
            return View(new Order());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Order(Order order)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Title"] = "Order Eldritch Tomes - Error";
                return View(order);
            }

            var confirm= new Order
            {
                BookTitle = order.BookTitle,
                Email = order.Email,
                Address = order.Address
            };

            return RedirectToAction("Success", confirm);
        }

        [HttpGet]
        public IActionResult Success(Order confirm)
        {
            ViewData["Title"] = "Order Confirmed";
            return View(confirm);
        }
    }
    

    /*
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
    */
}