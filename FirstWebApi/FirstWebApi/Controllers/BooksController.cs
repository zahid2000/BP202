using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public IActionResult Book() { 
        
            return Ok(new
            {
                name="LOTR"
            });
        
        }
    }
}
