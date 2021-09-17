using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;

namespace DataAccess.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public List<Blog> ListAllBlog()
        {
            using var context = new Context();
            return context.Blogs.ToList();
        }

        public void AddBlog(Blog blog)
        {
            using var context = new Context();
            context.Add(blog);
            context.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            using var context = new Context();
            context.Remove(blog);
            context.SaveChanges();
        }

        public void UpdateBlog(Blog blog)
        {
            using var context = new Context();
            context.Update(blog);
            context.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var context = new Context();
            return context.Blogs.Find(id);
        }
    }
}