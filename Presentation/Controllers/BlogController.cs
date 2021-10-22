using System;
using System.Collections.Generic;
using System.Linq;
using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public IActionResult BlogListByAuthor()
        {
            var values = _blogManager.GetBlogListWithCategoryByAuthor(5);
            return View(values);
        }

        public IActionResult AddBlog()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categories = (from x in categoryManager.GetList()
                select new SelectListItem
                {
                    Text = x.CategoryName,
                    Value = x.CategoryId.ToString()
                }).ToList();
            
            ViewBag.category = categories;
            
            return View();
        }

        [HttpPost]
        public IActionResult AddBlog(Blog blog)
        {
            var blogValidator = new BlogValidator();
            var result = blogValidator.Validate(blog);

            if (result.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                blog.AuthorId = 5;
                _blogManager.Add(blog);
                return RedirectToAction("BlogListByAuthor", "Blog");
            }

            foreach (var item in result.Errors) ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

            return View();
        }
    }
}