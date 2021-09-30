using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void AddComment(Comment comment)
        {
            throw new System.NotImplementedException();
        }

        public List<Comment> GetListAll(int id)
        {
            return _commentDal.GetListAll(x => x.BlogId == id);
        }
    }
}