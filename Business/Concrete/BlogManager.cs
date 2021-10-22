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

        public List<Blog> GetList3Blog()
        {
            return _blogDal.GetListAll().TakeLast(3).ToList();
        }

        public void Add(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void Delete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogListWithCategoryByAuthor(int id)
        {
            return _blogDal.GetListWithCategoryByAuthor(id);
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