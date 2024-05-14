using Microsoft.AspNetCore.Mvc;

namespace MultiShopTemplate.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
