using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using DataAccess.Repositories;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using var ctx = new Context();
            return ctx.Blogs.Include(x => x.Category).ToList();
        }

        public List<Blog> GetListWithCategoryByAuthor(int id)
        {
            using var ctx = new Context();
            return ctx.Blogs.Include(x => x.Category).Where(x => x.AuthorId == id).ToList();
        }
    }
}