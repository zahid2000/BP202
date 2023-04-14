using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApiBB202.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [Required,MaxLength(255)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        [DefaultValue(false)]
        public bool IsDelete { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
