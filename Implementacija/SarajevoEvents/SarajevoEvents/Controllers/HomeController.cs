using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SarajevoEvents.Models;

namespace SarajevoEvents.Controllers
{

    public class HomeController : Controller
    {
        private Random rnd = new Random();
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDataContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDataContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["rnd"] = rnd;
            return View();
        }

        public IActionResult Ukratko()
        {
            return View();
        }

        public IActionResult Znamenitosti()
        {
            return View();
        }

        public IActionResult KadaPosjetiti()
        {
            return View();
        }

        public IActionResult MorateProbati()
        {
            return View();
        }

        public IActionResult SarajevoFilmFestival()
        {
            return View();
        }

        public IActionResult ZastoPosjetiti()
        {
            return View();
        }

        public IActionResult Prognoza()
        {
            return View();
        }

       

        public IActionResult GdjeOtici()
        {
            ViewData["rnd"] = rnd;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
