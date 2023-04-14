namespace WebApiConfig.DTOs.Product
{
    public class ProductGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}
