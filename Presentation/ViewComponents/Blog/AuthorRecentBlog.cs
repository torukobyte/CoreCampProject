using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.Blog
{
    public class AuthorRecentBlog : ViewComponent
    {
        private readonly BlogManager _blogManager = new(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = _blogManager.GetBlogByAuthor(4);
            return View(values);
        }
    }
}