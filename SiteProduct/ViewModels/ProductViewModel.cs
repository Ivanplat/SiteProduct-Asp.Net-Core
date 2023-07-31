﻿namespace SiteProduct.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateTime ProductionTime { get; set; }
        public string Category { get; set; } = string.Empty;
    }
}
