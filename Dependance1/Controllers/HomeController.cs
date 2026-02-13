using System.Diagnostics;
using dependance.Models;
using dependance.services;
using Microsoft.AspNetCore.Mvc;

namespace dependance.Controllers
{
    public class HomeController : Controller
    {
        private readonly Imyservice _service;

        public HomeController(Imyservice service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            string message = _service.GetMessage();
            return Content(message);
        }
    }
}
