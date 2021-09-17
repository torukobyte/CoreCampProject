using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Repositories;
using Entity.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private EfCategoryRepository _efCategoryRepository;

        public CategoryManager()
        {
            _efCategoryRepository = new EfCategoryRepository();
        }

        public void AddCategory(Category category)
        {
            _efCategoryRepository.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            _efCategoryRepository.Delete(category);
        }

        public void UpdateCategory(Category category)
        {
            _efCategoryRepository.Update(category);
        }

        public List<Category> GetListAll()
        {
            return _efCategoryRepository.GetListAll();
        }

        public Category GetById(int id)
        {
            return _efCategoryRepository.GetById(id);
        }
    }
}