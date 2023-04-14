using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppMigration.DAL;
using WebAppMigration.Models;
using WebAppMigration.ViewModels;

namespace WebAppMigration.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HttpContext.Session.SetString("name", "Murad");
            Response.Cookies.Append("surname", "Haci", new CookieOptions
            {
                MaxAge = TimeSpan.FromSeconds(20)
            }); 
           
            HomeVM homeVM = new HomeVM
            {
                Sliders = await _context.Sliders.ToListAsync(),
                Categories = await _context.Categories.ToListAsync(),
                Services = await _context.Services
                .Include(s => s.Category)
                .Include(s => s.Images)
                .OrderByDescending(s => s.Id)
                .Take(4)
                .ToListAsync(),
            };
           
            return View(homeVM);
        }
      
        public IActionResult GetSession()
        {

            string name=HttpContext.Session.GetString("name");
            string surname = Request.Cookies["surname"];
            return Json(name+" "+surname);
        }


      


       
        
    }
}
