using System.Diagnostics;
using customservice.Models;
using Microsoft.AspNetCore.Mvc;
using customservice.services;

namespace customservice.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGettingservice _grettingservice;

        public HomeController(IGettingservice grettingservice)
        { 
        
            _grettingservice = grettingservice;
        }

        public IActionResult Index()
        {
            var message = _grettingservice.Getmessage("Lisha");
            ViewBag.Message = message;
            return View();
        }

       
    }
}
