using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aitest.Models;
using Microsoft.Extensions.Configuration;

namespace aitest.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _config;

        public HomeController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Navbar()
        {
            ViewData["NavbarInstrumentationKey"] = _config.GetValue<string>("ApplicationInsights:NavbarInstrumentationKey");
            return PartialView("_Navbar");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
