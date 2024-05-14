using Microsoft.AspNetCore.Mvc;

namespace MultiShopTemplate.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Shop()
        {
            return View();
        }
    }
}
