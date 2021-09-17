using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;

namespace DataAccess.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        private Context _context = new Context();

        public List<Category> ListAllCategory()
        {
            return _context.Categories.ToList();
        }

        public void AddCategory(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
        }

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }
    }
}