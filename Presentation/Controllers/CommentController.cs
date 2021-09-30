using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class CommentController : Controller
    {
        private readonly CommentManager _commentManager = new(new EfCommentRepository());


        // public IActionResult Index()
        // {
        //     return View();
        // }

        public PartialViewResult CommentsInBlog(int id)
        {
            var values = _commentManager.GetListAll(id);
            return PartialView(values);
        }

        public PartialViewResult AddComment()
        {
            return PartialView();
        }
    }
}