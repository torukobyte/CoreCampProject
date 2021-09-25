using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class CommentController : Controller
    {
        // public IActionResult Index()
        // {
        //     return View();
        // }

        public PartialViewResult CommentsInBlog()
        {
            return PartialView();
        }

        public PartialViewResult AddComment()
        {
            return PartialView();
        }
    }
}