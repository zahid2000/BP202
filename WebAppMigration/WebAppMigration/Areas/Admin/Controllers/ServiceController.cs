using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppMigration.Areas.Admin.ViewModels.ServiceVM;
using WebAppMigration.DAL;
using WebAppMigration.Models;
using WebAppMigration.Utilities.Extensions;
using WebAppMigration.ViewModels;

namespace WebAppMigration.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly AppDbContext _context;
        private string _errorMessages;
        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index(int currentPage=1,int take=5)
        {
            List<Service> services= await _context.Services
                .Where(s=>!s.IsDeleted)
                .OrderByDescending(s=>s.Id)
                .Skip((currentPage - 1)*take)
                .Take(take)
                .Include(s=>s.Category)
                .Include(s=>s.Images)
                .ToListAsync();

            int pageCount = await GetPageCount(take);
            PaginateVM<Service> model = new PaginateVM<Service>
            {
                Models= services,
                CurrentPage= currentPage,
                PageCount=pageCount,
                Previous= currentPage > 1,
                Next= currentPage < pageCount
            };
            return View(model);
        }
       
        private async Task<int> GetPageCount(int take)
        {
            int productCount = await _context.Services.CountAsync();
            return (int)Math.Ceiling((decimal)productCount / take);
        }
        public async Task<IActionResult> Show(int id)
        {
            Service service = await _context.Services.Where(s => s.Id == id).Include(s => s.Category).Include(s => s.Images).FirstOrDefaultAsync();
            if (service == null) return NotFound();
            return View(service);
        }

        public async Task<IActionResult> Create()
        {
            ServiceVM model = new ServiceVM
            {
                Categories = await _context.Categories.Where(c => !c.IsDeleted).ToListAsync()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServiceVM serviceVM)
        {
            serviceVM.Categories = await _context.Categories.Where(c => !c.IsDeleted).ToListAsync();
            if (!ModelState.IsValid) return View(serviceVM);
            if (!CheckFile(serviceVM.Images, "image/", 200))
            {
                ModelState.AddModelError("Images", _errorMessages);
            }
            List<ServiceImage> images = await CreateImageFiles(serviceVM);
            Service service = new Service
            {
                Name = serviceVM.Name,
                Images = images,
                CategoryId = serviceVM.CategoryId,
                Price = serviceVM.Price,
                Description = serviceVM.Description
            };

            _context.Services.Add(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private static async Task<List<ServiceImage>> CreateImageFiles(ServiceVM serviceVM)
        {
            List<ServiceImage> images = new List<ServiceImage>();
            string root = Path.Combine(Environment.CurrentDirectory, "wwwroot", "assets", "img");
            foreach (IFormFile file in serviceVM.Images)
            {
                string fileName = await file.SaveFileAsync(root);
                ServiceImage serviceImage = new ServiceImage { Path = fileName };
                if (!images.Any(i => i.IsMain)) serviceImage.IsMain = true;
                images.Add(serviceImage);

            }

            return images;
        }

        private bool CheckFile(List<IFormFile> files, string fileType, decimal sizeByKb)
        {
            foreach (IFormFile file in files)
            {
                if (file.CheckFileType(fileType))
                {
                    _errorMessages = $"{file.FileName} file type must be image type";
                    return false;
                }
                if (file.CheckFileSize(sizeByKb))
                {
                    _errorMessages = $"{file.FileName} file size must be less than 200kb";

                    return false;
                }
            }
            return true;
        }


    }
}
