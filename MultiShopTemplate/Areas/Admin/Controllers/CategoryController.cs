using Microsoft.AspNetCore.Mvc;
using MultiShop.Business.Services.Abstract;
using MultiShop.Core.Models;

namespace MultiShopTemplate.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var categories = _categoryService.GetAllCategories();
            return View(categories);
        }

        public IActionResult Create() 
        { 
            
            return View();

        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View()
;            }

            _categoryService.AddCategory(category);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var category = _categoryService.GetCategory(x => x.Id == id);
            if (category is null)
            {
                throw new NullReferenceException();
            }
            _categoryService.DeleteCategory(id);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var category = _categoryService.GetCategory(x => x.Id == id);
            if (category is null)
            {
                throw new NullReferenceException();
            }
            return View(category);

        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _categoryService.UpdateCategory(category,category.Id);

            return RedirectToAction("Index");
        }


    }
}
