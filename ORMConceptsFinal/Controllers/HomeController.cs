using Microsoft.AspNetCore.Mvc;
using ORMConceptsFinal.Models;
using System.Diagnostics;
using ORMConceptsFinal.Data;

namespace ORMConceptsFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ChoreContext _context;

        public HomeController(ILogger<HomeController> logger, ChoreContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
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