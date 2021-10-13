using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetListAll()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetList3Blog()
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogByAuthor(int id)
        {
            return _blogDal.GetListAll(x => x.AuthorId == id);
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetListAll(x => x.BlogId == id);
        }
    }
}