using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppMigration.DAL;
using WebAppMigration.Models;

namespace WebAppMigration.Controllers
{
    public class AboutController :Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List < Slider > sliders= await _context.Sliders.ToListAsync();
            return View(sliders) ;
        }
    }
}
