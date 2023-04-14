using Business.Services.Abstract;
using Entities.DTOs.Product;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateDto productCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return View(productCreateDto);
            }
            var result = await _productService.CreateAsync(productCreateDto);
            if (!result.Success)
            {
               
                return View(productCreateDto);
            }
            return RedirectToAction("Index", "Home");


        }
    }
}
