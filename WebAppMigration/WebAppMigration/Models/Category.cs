

using System.ComponentModel.DataAnnotations;

namespace WebAppMigration.Models
{
    public class Category
    {
        public Category()
        {
            Services = new List<Service>();
        }
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public List<Service> Services { get; set; }
    }
}
