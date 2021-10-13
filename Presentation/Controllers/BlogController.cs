using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        private readonly BlogManager _blogManager = new(new EfBlogRepository());

        public IActionResult Index()
        {
            var values = _blogManager.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogDetails(int id)
        {
            ViewBag.id = id;
            var values = _blogManager.GetBlogById(id);
            return View(values);
        }
    }
}