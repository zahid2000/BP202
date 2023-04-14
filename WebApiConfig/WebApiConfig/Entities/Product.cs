using System.ComponentModel.DataAnnotations;

namespace WebApiConfig.Entities
{
    public class Product
    {
        public int Id { get; set; }      
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
