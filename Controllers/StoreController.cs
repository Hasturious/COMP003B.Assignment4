using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace COMP003B.Assignment4.Controllers
{
    public class StoreController : Controller
    {  
        //sends user to order page
        [HttpGet]
        public IActionResult Order(int id)
        {
            return View(new Order());
        }
        //logs the order details 
        [HttpPost]
        public IActionResult Order(Order order)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Title"] = "Invalid Order Form";
                return View(order);
            }

            return RedirectToAction("Success", new
            {
                BookTitle = order.BookTitle,
                Amount = order.Amount,
                Email = order.Email,
                Address = order.Address
            });
        }
        //sends user to success page

        [HttpGet]
        public IActionResult Success(string bookTitle, int amount, string email, string address)
        {
            var order = new Order
            {
                BookTitle = bookTitle,
                Amount = amount,
                Email = email,
                Address = address
            };            
            return View(order);
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