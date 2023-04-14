using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FirstWebApi.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
