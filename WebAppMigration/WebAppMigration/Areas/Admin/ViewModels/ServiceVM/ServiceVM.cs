using Microsoft.Build.Framework;
using WebAppMigration.Models;

namespace WebAppMigration.Areas.Admin.ViewModels.ServiceVM
{
    public class ServiceVM
    {
        public ServiceVM()
        {
            Categories = new List<Category>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public List<IFormFile> Images { get; set; }
        public List<Category> Categories { get; set; }
    }
}
