using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Th_01_02.Models;

namespace Th_01_02.Controllers
{
    public class HomeController : Controller
    {
        
        private IProductRepository productRepository;

        public HomeController(IProductRepository pro)
        {
           this.productRepository = pro;
        }

        public IActionResult Index()
        {
            return View(productRepository.GetTrendingProducts());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
