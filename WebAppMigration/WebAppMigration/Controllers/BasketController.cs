using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WebAppMigration.DAL;
using WebAppMigration.ViewModels;

namespace WebAppMigration.Controllers
{
    public class BasketController : Controller
    {
        public const string COOKIES_BASKET = "basket";
        private readonly AppDbContext _context;

        public BasketController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            List<BasketVM> basketVM = GetBasketVM();
            List<BasketItemVM> model=new List<BasketItemVM>();  
            foreach (var item in basketVM)
            {
                var service= await _context.Services
                    .Where(s=>s.Id==item.ServiceId&&!s.IsDeleted)
                    .Include(s=>s.Images)
                    .Include (s=>s.Category)
                    .FirstOrDefaultAsync();
                BasketItemVM basketItem=new BasketItemVM()
                {
                    Id=item.ServiceId,
                    ServiceCount=item.Count,
                    Name = service.Name,
                    Price = service.Price,
                    CategoryName = service.Category.Name,
                    ImagePath = service.Images.Where(i => i.IsMain).FirstOrDefault().Path,
                    IsDeleted = service.IsDeleted
                };

                model.Add(basketItem);
            }

            return View(model);
        }

        public IActionResult AddBasket(int id)
        {
            if (id==0)
            {
                return NotFound();
            }
            var dbService=_context.Services.Where(s=>s.Id==id&&!s.IsDeleted).FirstOrDefault();
            if (dbService==null) {
                return BadRequest();
            }

            List<BasketVM> basketVM = GetBasketVM();
            CheckBasketVM(id, basketVM);
            UpdateCookie(basketVM);

            return RedirectToAction("index", "Services");

        }

        private void UpdateCookie(List<BasketVM> basketVM)
        {
            string cookiesBasket = JsonConvert.SerializeObject(basketVM);
            Response.Cookies.Append(COOKIES_BASKET, cookiesBasket);
        }

        private void CheckBasketVM(int id, List<BasketVM> basketVM)
        {
            BasketVM existsBasket = basketVM.FirstOrDefault(b => b.ServiceId == id);
            if (existsBasket != null)
            {
                existsBasket.Count++;
            }
            else
            {
                basketVM.Add(new BasketVM { ServiceId = id, Count = 1 });
            }
        }

        private List<BasketVM> GetBasketVM() {


            List<BasketVM> basketVM;

            if (Request.Cookies[COOKIES_BASKET] != null)
            {
                basketVM = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies[COOKIES_BASKET]);

            }
            else
            {
                basketVM = new List<BasketVM>();
            }
            return basketVM;
        }

        

    }
}
