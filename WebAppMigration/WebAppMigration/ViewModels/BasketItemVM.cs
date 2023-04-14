﻿using WebAppMigration.Models;

namespace WebAppMigration.ViewModels
{
    public class BasketItemVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ServiceCount { get; set; }
        public bool IsDeleted { get; set; }
        public string CategoryName { get; set; }
        public string ImagePath { get; set; }

    }
}
