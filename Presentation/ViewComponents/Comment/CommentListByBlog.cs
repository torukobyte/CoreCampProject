using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        private readonly CommentManager _commentManager = new(new EfCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = _commentManager.GetListAll(id);
            return View(values);
        }
    }
}