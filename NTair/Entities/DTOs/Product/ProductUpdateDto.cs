namespace Entities.DTOs.Product;

public class ProductUpdateDto:IDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }
}
