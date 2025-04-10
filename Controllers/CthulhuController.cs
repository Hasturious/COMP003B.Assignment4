using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    [Route("/call-of-cthulhu")]
    public class CthulhuController : Controller
    {
        //GET /call-of-cthulhu
        //Displays the gamespecs page
        [HttpGet]
        [Route("")]
        public IActionResult GameSpecs()
        {
            ViewData["Title"] = "Call of Cthulhu - Specifications";
            return View();
        }

        //POST /call-of-cthulhu/subscribe
        //This adds a form to "subscribe" to a sort of newletter
        [HttpPost]
        [Route("subscribe")]
        public IActionResult Subscribe(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                ModelState.AddModelError("", "Email is required");
                return RedirectToAction("GameSpecs");
            }

            //This is purely cosmetic because we don't really have a database connected to this
            return RedirectToAction("GameSpecs", new { subscribed = true });
        }

        //GET /productlist
        //Displays the productlist page
        //This is where the rulebook model goes
        [HttpGet]
        [Route("/productlist")]
        public IActionResult ProductList()
        {
            List<Rulebook> rulebooks = new()
            {
                new Rulebook
                {
                    Title = "Call of Cthulhu Keeper Rulebook",
                    Edition = 7,
                    Publication = 2023,
                    PageNumbers = 200
                },
                new Rulebook
                {
                    Title = "Pulp Cthulhu",
                    Edition = 7,
                    Publication = 2020,
                    PageNumbers = 300
                },
                new Rulebook
                {
                    Title = "Malleus Monstrorum",
                    Edition = 7,
                    Publication = 2021,
                    PageNumbers = 400
                }
            };
            return View(rulebooks);
        }
    }
}