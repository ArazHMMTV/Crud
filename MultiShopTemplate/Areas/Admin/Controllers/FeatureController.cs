using Microsoft.AspNetCore.Mvc;

namespace MultiShopTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
