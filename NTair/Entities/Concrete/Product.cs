﻿namespace Entities.Concrete;

public   class Product:IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedDate { get; set; }
}
