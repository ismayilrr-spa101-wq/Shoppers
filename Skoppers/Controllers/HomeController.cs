using Microsoft.AspNetCore.Mvc;
using Skoppers.Data;
using Skoppers.Models.Product;

namespace Skoppers.Controllers
{
    public class HomeController : Controller
    {
        private ShoppersDBcontext _context { get; }
        public HomeController(ShoppersDBcontext context)
        {
            
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> products = _context.Products.ToList();
            return View(products);
        }
    }
}
