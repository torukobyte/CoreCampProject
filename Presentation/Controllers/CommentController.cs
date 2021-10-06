using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
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

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Now;
            comment.CommentStatus = true;
            comment.BlogId = 15;
            _commentManager.AddComment(comment);
            return RedirectToAction("Index","Blog");
        }
    }
}