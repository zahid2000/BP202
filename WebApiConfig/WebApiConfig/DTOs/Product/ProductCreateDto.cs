namespace WebApiConfig.DTOs.Product
{
    public class ProductCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}
