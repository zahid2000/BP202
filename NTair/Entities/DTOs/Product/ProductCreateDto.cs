﻿namespace Entities.DTOs.Product;

public class ProductCreateDto:IDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }
}
