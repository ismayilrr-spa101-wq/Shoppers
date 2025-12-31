using Microsoft.AspNetCore.Mvc;

namespace Skoppers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
