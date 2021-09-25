using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());
        
        // GET
        public IActionResult Index()
        {
            var values = _categoryManager.GetListAll();
            return View(values);
        }
    }
}