using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoDatchi.Models;
using Microsoft.AspNetCore.Http;

namespace DojoDatchi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Datchi Nadia = new Datchi();

            HttpContext.Session.SetInt32("Fullness", 20);            
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");

            HttpContext.Session.SetInt32("Happiness", 20);            
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");

            HttpContext.Session.SetInt32("Meals", 5);            
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");

            HttpContext.Session.SetInt32("Energy", 50);            
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");

            return View();
        }

        [HttpGet("feed")]
        public IActionResult Feed ()
        {
    
            Random Rand = new Random();
            int? Full = HttpContext.Session.GetInt32("Fullness");
            Full = Full + Rand.Next(5,10);
            HttpContext.Session.SetInt32("Fullness", (int)Full);
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            
            int? Meals = HttpContext.Session.GetInt32("Meals");
            if(Meals >0)
            {
                Meals--;
                HttpContext.Session.SetInt32("Meals", (int)Meals);
                ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
                
                string Message = new string("You fed your Datchi!");
                ViewBag.Message = Message;
            }
            else 
            {
                ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
                string Message = new string("Your Datchi ran out of meals");
                ViewBag.Message = Message;
            }

            HttpContext.Session.SetInt32("Happiness", 20);            
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");

            HttpContext.Session.SetInt32("Energy", 50);            
            ViewBag.Energy = HttpContext.Session.GetInt32("Energy");

            return View("Index");
        }

        [HttpGet("play")]
        public IActionResult Play()
        {
            Random Rand = new Random();
            int? Happy = HttpContext.Session.GetInt32("Happiness");
            Happy = Happy + Rand.Next(5,10);
            HttpContext.Session.SetInt32("Happiness", (int)Happy);
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");
            
            int? Energy = HttpContext.Session.GetInt32("Energy");
            if(Energy > 0)
            {
                Energy-=5;
                HttpContext.Session.SetInt32("Energy", (int)Energy);
                ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
                
                string Message = new string("You played with your Datchi!");
                ViewBag.Message = Message;
            }
            // else 
            // {
            //     ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
            //     string Message = new string("Your Datchi ran out of energy");
            //     ViewBag.Message = Message;
            // }

            HttpContext.Session.SetInt32("Meals", 5);            
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");

            HttpContext.Session.SetInt32("Fullness", 20);            
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");

            return View("Index");
        }

        [HttpGet("work")]
        public IActionResult Work()
        {
            Random Rand = new Random();
            int? Meals = HttpContext.Session.GetInt32("Meals");
            Meals = Meals + Rand.Next(1,3);
            HttpContext.Session.SetInt32("Meals", (int)Meals);
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
            
            int? Energy = HttpContext.Session.GetInt32("Energy");
            if(Energy > 0)
            {
                Energy-=5;
                HttpContext.Session.SetInt32("Energy", (int)Energy);
                ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
                
                string Message = new string("Your Datchi worked hard");
                ViewBag.Message = Message;
            }
            else 
            {
                ViewBag.Energy = HttpContext.Session.GetInt32("Energy");
                string Message = new string("Your Datchi ran out of energy");
                ViewBag.Message = Message;
            }

            HttpContext.Session.SetInt32("Happiness", 20);            
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");

            HttpContext.Session.SetInt32("Fullness", 20);            
            ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
            return View("Index");
        }

        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            {
            Random Rand = new Random();
            int? Energy = HttpContext.Session.GetInt32("Energy");
            Energy = Energy + Rand.Next(5,15);
            HttpContext.Session.SetInt32("Energy", (int)Energy);
            ViewBag.Energy = HttpContext.Session.GetInt32("Meals");
            
            int? Fullness = HttpContext.Session.GetInt32("Fullness");
            if(Fullness > 0)
            {
                Fullness-=5;
                HttpContext.Session.SetInt32("Fullness", (int)Fullness);
                ViewBag.Fullness = HttpContext.Session.GetInt32("Fullness");
                
                string Message = new string("Your Datchi slept!");
                ViewBag.Message = Message;
            }
            else 
            {
                ViewBag.Energy = HttpContext.Session.GetInt32("Fullness");
                string Message = new string("Your Datchi is too hungry");
                ViewBag.Message = Message;
            }

            HttpContext.Session.SetInt32("Happiness", 20);            
            ViewBag.Happiness = HttpContext.Session.GetInt32("Happiness");

            HttpContext.Session.SetInt32("Meals", 5);            
            ViewBag.Meals = HttpContext.Session.GetInt32("Meals");
            return View("Index");
            }
        }

        [HttpGet("Reset")]
        public IActionResult Reset()
        {
            if(ViewBag.Energy < 0)
            {
                HttpContext.Session.Clear();
                string Message = new string("Your Datchi has fallen");
                ViewBag.Message = Message;
            }
            
            if(ViewBag.Happiness > 100 || ViewBag.Energy > 100 || ViewBag.Fullness > 100)
            {
                HttpContext.Session.Clear();
            }

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
