using System.Collections.Generic;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment comment);

        // void DeleteComment(Comment comment);

        // void UpdateComment(Comment comment);

        List<Comment> GetListAll(int id);

        // Comment GetById(int id);
    }
}