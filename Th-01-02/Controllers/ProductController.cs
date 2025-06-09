using Microsoft.AspNetCore.Mvc;
using Th_01_02.Models;
using Th_01_02.Models.Services;

namespace Th_01_02.Controllers
{
    public class Product : Controller
    {
        private IProductRepository ProductRepository;

        public Product()
        {
        }

        Product(IProductRepository ProductRepository)
        {
            this.ProductRepository = ProductRepository;
        }

        public string Name { get; internal set; }
        public int Id { get; internal set; }
        public decimal Price { get; internal set; }
        public string ImageUrl { get; internal set; }

        public IActionResult Detail(int id)
        {
            var product = ProductRepository.GetProductDetail(id);
            if (product != null)
            {
                return View(product);
            }
            return NotFound();
        }
        public IActionResult Shop()
        {
            return View(ProductRepository.GetAllProducts());
        }
    }
}
