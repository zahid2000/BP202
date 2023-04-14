using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppMigration.DAL;

namespace WebAppMigration.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AppDbContext _context;

        public ServicesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var services = await _context.Services
                .Take(8)
                .Include(s => s.Category)
                .Include(s => s.Images)
                .ToListAsync();
            ViewBag.ServicesCount = await _context.Services.CountAsync();
            return View(services);
        }
      
        public IActionResult LoadMore(int skip)
        {
           
            var services = _context.Services
                            .Skip(skip) 
                            .Take(4)
                            .Include(s => s.Category)
                            .Include(s => s.Images)
                            .ToList();            

            return PartialView("_ServicesPartialView",services);
        }
    }
}
