using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);

        void DeleteBlog(Blog blog);

        void UpdateBlog(Blog blog);

        List<Blog> GetListAll();

        Blog GetById(int id);

        List<Blog> GetBlogListWithCategory();
    }
}