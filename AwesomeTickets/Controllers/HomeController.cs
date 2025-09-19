using System.Diagnostics;
using AwesomeTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AwesomeTickets.Data;

namespace AwesomeTickets.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;   

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Edit Index?home shows event list
        public async Task<IActionResult> Index()
        {
            var events = await _context.Events
                .OrderByDescending(e => e.CreatedAt)
                .ToListAsync();
            return View(events);
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
