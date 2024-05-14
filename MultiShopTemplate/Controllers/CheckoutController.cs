using Microsoft.AspNetCore.Mvc;

namespace MultiShopTemplate.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
