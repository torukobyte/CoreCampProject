using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.Blog
{
    public class BlogLast3Post : ViewComponent
    {
        private readonly BlogManager _blogManager = new(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = _blogManager.GetList3Blog();
            return View(values);
        }
    }
}