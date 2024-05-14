using MultiShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business.Services.Abstract
{
    public interface ICategoryService
    {
        void AddCategory(Category  category);
        void DeleteCategory(int id);

        void UpdateCategory(Category newCategory,int id);

        Category GetCategory(Func<Category, bool>? func=null);
        List<Category> GetAllCategories(Func<Category,bool>? func=null);
    }
}
