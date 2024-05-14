using Microsoft.AspNetCore.Mvc;
using MultiShop.Business.Services.Abstract;
using MultiShop.Data.RepositoryAbstract;
using System.Diagnostics;

namespace MultiShopTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFeatureService _featureService;
        public HomeController(IFeatureService featureService)
        {
            _featureService = featureService;
        }
        public IActionResult Index()
        {
            var features = _featureService.GetAllFeatures();
            return View(features);
        }
    }
}
