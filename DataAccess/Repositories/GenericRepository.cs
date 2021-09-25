using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Insert(T t)
        {
            using var context = new Context();
            context.Add(t);
            context.SaveChanges();
        }

        public void Delete(T t)
        {
            using var context = new Context();
            context.Remove(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new Context();
            context.Update(t);
            context.SaveChanges();
        }

        public List<T> GetListAll()
        {
            using var context = new Context();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var context = new Context();
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using var context = new Context();
            return context.Set<T>().Where(filter).ToList();
        }
    }
}