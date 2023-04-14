using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApiConfig.DAL.Repositories;
using WebApiConfig.DAL.Repositories.Abstracts;
using WebApiConfig.DTOs.Product;
using WebApiConfig.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiConfig.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        [HttpGet]
        //[Authorize]
        public async Task<ActionResult<List<ProductGetDto>>> Get()
        {
            List<ProductGetDto> products = _mapper.Map<List<ProductGetDto>>(await _unitOfWork.ProductRepository.GetAllAsync(p => !p.IsDeleted));
            return Ok(products);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ProductGetDto>> Get(int id)
        {
            Product product = await _unitOfWork.ProductRepository.GetAsync(p => p.Id == id && !p.IsDeleted);
            if (product == null)
            {
                return NotFound();
            }

            ProductGetDto productDto = _mapper.Map<ProductGetDto>(product);
            return productDto;
        }

        [HttpPost]
        //[Authorize(Roles = "admin")]

        public async Task Post([FromBody] ProductCreateDto productCreateDto)
        {
            Product product = _mapper.Map<Product>(productCreateDto);
            await _unitOfWork.ProductRepository.CreateAsync(product);
            await _unitOfWork.SaveAsync();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            var product = await _unitOfWork.ProductRepository.GetAsync(p => p.Id == id);
            if (product is null)
            {
                NotFound();
            }
            _unitOfWork.ProductRepository.Delete(product);
            await _unitOfWork.SaveAsync();
        }
    }
}
