using SiteProduct.Models;
using System.ComponentModel;

namespace SiteProduct.Services
{
    public class MockProductData : IProductData
    {
        private List<Product> _products;
        public MockProductData()
        {
            _products = new List<Product>
            {
                new Product{Id = 1, Name="C# 4.0", Price=750.0M, ProductionTime= DateTime.Parse("01.03.2019"), CategoryId=2},
                new Product{Id = 2, Name="Random access memory", Price=1975.0M, ProductionTime= DateTime.Parse("01.05.2021"), CategoryId=3},
                new Product{Id = 3, Name="Apple iPhone SE", Price=34789.0M, ProductionTime= DateTime.Parse("01.12.2020"), CategoryId=4},
            };
        }
        public IEnumerable<Product> GetAll()
        {
            return _products;
        }
        public Product Get(int id)
        {
            return _products.FirstOrDefault(x => x.Id.Equals(id)) ?? new Product() { Id = -1 };
        }
        public int Add(Product newProduct)
        {
            newProduct.Id = _products.Max(p => p.Id) + 1;
            _products.Add(newProduct);
            return newProduct.Id;
        }
        public void Save(Product product)
        {
            _products.Where(x => x.Id == product.Id).ToList().ForEach(p =>
            {
                p.Name = product.Name;
                p.Price = product.Price;
                p.ProductionTime = product.ProductionTime;
                p.CategoryId = product.CategoryId;
            });
        }
    }
}
