using Business.Services.Abstract;
using Core.Utilities.Exceptions;
using Core.Utilities.Results;
using Entities.DTOs.Product;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
       
            var result=await _productService.GetAllAsync()
            ;
            if (!result.Success)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

    [HttpGet("getbyid/{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var result=await _productService.GetByIdAsync(id);
        if (!result.Success)
        {
            return BadRequest(result);
        }
        return Ok(result);
    }
    [HttpGet("getbyname/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
         var result = await _productService.GetByNameAsync(name);        
        if (!result.Success)
        {
            return BadRequest(result);
        }
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ProductCreateDto productCreateDto)
    {
        var result= await _productService.CreateAsync(productCreateDto);
        if (!result.Success)
        {
            return BadRequest(result);
        }
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Update(ProductUpdateDto productUpdateDto)
    {
      var result=  await _productService.UpdateAsync(productUpdateDto);
        if (!result.Success)
        {
            return BadRequest(result);
        }
        return Ok(result);
    }
}
