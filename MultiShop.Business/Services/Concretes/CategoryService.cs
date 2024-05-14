using MultiShop.Business.Services.Abstract;
using MultiShop.Business.Services.Exceptions;
using MultiShop.Core.Models;
using MultiShop.Data.DAL;
using MultiShop.Data.RepositoryAbstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Business.Services.Concretes
{
    public class CategoryService : ICategoryService
    {
        public ICategoryRepository _categoryrepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryrepository = categoryRepository;
        }
        public void AddCategory(Category category)
        {
            if (!_categoryrepository.GetAll().Any(x => x.Name == category.Name))
            {
                _categoryrepository.Add(category);
                _categoryrepository.Commit();
            }
            else
                throw new DuplicateExceptions("Bele bir category yoxdur!");
        }

        public void DeleteCategory(int id)
        {
           Category exsistCategory = _categoryrepository.Get(x=> x.Id == id);
            if (exsistCategory == null) throw new NullReferenceException("Category yoxdur!");
            _categoryrepository.Delete(exsistCategory);
            _categoryrepository.Commit();   
        }

        public List<Category> GetAllCategories(Func<Category, bool>? func = null)
        {
              return _categoryrepository.GetAll(func);
        }

        public Category GetCategory(Func<Category, bool>? func = null)
        {
            return _categoryrepository.Get(func);
        }

        public void UpdateCategory(Category newCategory, int id)
        {
            Category oldCategory = _categoryrepository.Get(x=> x.Id == id);
            if (oldCategory == null) throw new NullReferenceException("Null");

            if (!_categoryrepository.GetAll().Any(x => x.Name == newCategory.Name))
            {
                oldCategory.Name = newCategory.Name;
                _categoryrepository.Commit();
            }
            else
                throw new DuplicateExceptions("Bele bir category yoxdur!");
        }
    }
}
