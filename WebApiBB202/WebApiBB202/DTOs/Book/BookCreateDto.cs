using System.ComponentModel.DataAnnotations;

namespace WebApiBB202.DTOs.Book
{
    public class BookCreateDto
    {
        [Required, MaxLength(255)]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
