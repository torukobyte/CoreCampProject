using System.Collections.Generic;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Repositories
{
    public class CommentRepository : IGenericDal<Comment>
    {
        public void Insert(Comment t)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Comment t)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Comment t)
        {
            throw new System.NotImplementedException();
        }

        public List<Comment> GetListAll()
        {
            throw new System.NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}