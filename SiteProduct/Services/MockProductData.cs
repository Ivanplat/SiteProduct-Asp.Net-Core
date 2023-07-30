﻿using SiteProduct.Models;

namespace SiteProduct.Services
{
    public class MockProductData : IProductData
    {
        private List<Product> _products;
        public MockProductData()
        {
            _products = new List<Product>
            {
                new Product{Id = 1, Name="C# 4.0", Price=750.0M, ProductionTime= DateTime.Parse("01.03.2019")},
                new Product{Id = 2, Name="Random access memory", Price=1975.0M, ProductionTime= DateTime.Parse("01.05.2021")},
                new Product{Id = 3, Name="Apple iPhone SE", Price=34789.0M, ProductionTime= DateTime.Parse("01.12.2020")},
            };
        }
        public IEnumerable<Product> GetAll()
        {
            return _products;
        }
    }
}