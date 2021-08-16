using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstMVC.Models;

namespace firstMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        static List<Pet> myPets = new List<Pet>();

        [HttpGet("")]
        public IActionResult Index()
        {
            // List<string> petNames = new List<string>{
            //     "Buddy",
            //     "Flufffy",
            //     "Cat",
            //     "Spot"
            // };
            // ViewBag.message = "Some sort of message!";
            // return View(petNames);
            return View(myPets);
        }

        [HttpGet("Form")]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost("Add")]
        public IActionResult Add(Pet newPet)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("*******************");
                Console.WriteLine($"Name: {newPet.Name}");
                Console.WriteLine("*******************");
                myPets.Add(newPet);
                // checked to see if it works
                // return View("Results", newPet);
                return RedirectToAction("Index");
            } else {
                Console.WriteLine("Something went wrong w the model!");
                return View("Form");
            }

        }
    }
}
