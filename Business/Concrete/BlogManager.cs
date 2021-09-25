using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        private IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddBlog(Blog blog)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new System.NotImplementedException();
        }

        public List<Blog> GetListAll()
        {
            return _blogDal.GetListAll();

        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetListAll(x => x.BlogId == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }
    }
}