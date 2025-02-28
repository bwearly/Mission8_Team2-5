using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
//using Mission8_Team2_5.Models;

namespace Mission8_Team2_5.Controllers
{
    public class HomeController : Controller
    {
        private TaskContext _context;
        public HomeController(TaskContext temp)
        {
            _context = temp;
        }

        public HomeController(ILogger<HomeController> logger) => _logger = logger;

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult TaskForm()
        {
            ViewBag.Categories = _context.Categories;

            return View();
        }

        public IActionResult TaskForm()
        {
            return Redirect("Delete");
        }
    }
}
