using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryManager _categoryManager = new(new EfCategoryRepository());

        // GET
        public IActionResult Index()
        {
            var values = _categoryManager.GetList();
            return View(values);
        }
    }
}