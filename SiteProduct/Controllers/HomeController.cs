﻿using Microsoft.AspNetCore.Mvc;
using SiteProduct.Models;
using SiteProduct.Services;
using SiteProduct.ViewModels;

namespace SiteProduct.Controllers
{
    public class HomeController : Controller
    {
        private IProductData _products;
        private ITypeProductData _category;

        public HomeController(IProductData products, ITypeProductData category)
        {
            _products = products;
            _category = category;
        }
        public ViewResult Index()
        {
            var model = _products.GetAll().Select(product => new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ProductionTime = product.ProductionTime,
                Category = _category.GetCategories().Where(x => x.Id == product.CategoryId).FirstOrDefault()?.TypeName ?? string.Empty
            });
            return View(model);
        }
        public IActionResult Details(int id) 
        {
            var model = _products.Get(id);
            if(model.Id == -1)
            {
                return RedirectToAction("Index");
            }
            var productViewModel = new ProductViewModel
            {
                Id = model.Id,
                Name = model.Name,
                Price = model.Price,
                ProductionTime = model.ProductionTime,
                Category = _category.GetCategories().Where(x => x.Id == model.CategoryId).FirstOrDefault()?.TypeName ?? string.Empty
            };
            return View(productViewModel);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product model) 
        { 
            if(ModelState.IsValid)
            {
                var newId = _products.Add(model);
                return RedirectToAction("Details", new { id = newId });
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        { 
            var product = _products.Get(id);
            if(product?.Id == -1 || product == null) 
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(int id, Product model)
        {
            var product = _products.Get(id);
            if (product?.Id == -1 || product == null || !ModelState.IsValid)
            {
                return View(model);
            }
            model.Id = product.Id;
            _products.Save(model);
            return RedirectToAction("Details", new { id = model.Id });
        }
    }
}