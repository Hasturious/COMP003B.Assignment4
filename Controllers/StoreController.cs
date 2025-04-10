using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    public class StoreController : Controller
    {
        //sends user to order page
        [HttpGet]
        public IActionResult Order()
        {
            return View(new Order());
        }
        //logs the order details 
        [HttpPost]
        public IActionResult Order(Order order)
        {
            if (!ModelState.IsValid)
            {
                return View(order);
            }

            var confirm = new Order
            {
                BookTitle = order.BookTitle,
                Amount = order.Amount,
                Email = order.Email,
                Address = order.Address
            };

            return RedirectToAction("Success", confirm);
        }
        //sends user to success paage
        [HttpGet]
        public IActionResult Success(Order confirm)
        {
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