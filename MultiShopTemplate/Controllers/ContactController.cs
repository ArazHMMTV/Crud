using Microsoft.AspNetCore.Mvc;

namespace MultiShopTemplate.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
