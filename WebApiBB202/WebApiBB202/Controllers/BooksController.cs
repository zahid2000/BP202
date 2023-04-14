using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using WebApiBB202.DAL;
using WebApiBB202.DAL.Repository.Abstract;
using WebApiBB202.DTOs.Book;
using WebApiBB202.Entities;

namespace WebApiBB202.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly IProductRepository _repository;

        public BooksController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> Books()
        {

            var result = await _appDbContext.Books.Where(b => !b.IsDelete).ToListAsync();
            return StatusCode((int)HttpStatusCode.OK, result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Book(int id)
        {

            var result = await _appDbContext.Books.Where(b => b.Id == id && !b.IsDelete).FirstOrDefaultAsync();
            if (result == null) return NotFound();
            return StatusCode((int)HttpStatusCode.OK, result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookCreateDto book)
        {
            if (book == null) return BadRequest(new
            {
                StatusCode = 1123,
                Message = "Object is invaid"
            });

            Book newBook = new Book()
            {
                Name = book.Name,
                Price = book.Price,
                IsDelete = false,
                CreatedDate = DateTime.Now
            };

            await _appDbContext.Books.AddAsync(newBook);
            _appDbContext.SaveChanges();
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, BookUpdateDto book)
        {
            if (!ModelState.IsValid) return BadRequest(new { StatusCode = 1123, Message = "Object is invaid" });


            var result = await _appDbContext.Books.FindAsync(id);
            if (result == null) { return NotFound(); }

            result.Name = book.Name;
            result.Price = book.Price;
            _appDbContext.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
         
            var result = await _appDbContext.Books.FindAsync(id);
            if (result == null) { return NotFound(); }

            result.IsDelete=true;
            _appDbContext.SaveChanges();
            return NoContent();
        }

    }
}
