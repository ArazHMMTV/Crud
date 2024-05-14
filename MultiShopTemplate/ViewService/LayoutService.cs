using MultiShop.Business.Services.Abstract;
using MultiShop.Core.Models;

namespace MultiShopTemplate.ViewService
{
    public class LayoutService
    {
        private readonly ICategoryService _categoryService;
        public LayoutService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        
        public List<Category> GetCategories()
        {
           return _categoryService.GetAllCategories();
        }
    }
}
