using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        void AddCategory(Category category);

        void DeleteCategory(Category category);

        void UpdateCategory(Category category);

        List<Category> GetListAll();

        Category GetById(int id);
    }
}