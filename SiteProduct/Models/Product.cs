using System.ComponentModel.DataAnnotations;

namespace SiteProduct.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(5), Display(Name = "Наименование")]
        public string Name { get; set; } = string.Empty;
        [Required, Range(0.01d, 1000.0d), Display(Name = "Цена")]
        public decimal Price { get; set; }
        [Required, Display(Name = "Дата изготовления")]
        public DateTime ProductionTime { get; set; }
        [Required, Display(Name = "Категория")]
        public int CategoryId { get; set; } 
    }
}
