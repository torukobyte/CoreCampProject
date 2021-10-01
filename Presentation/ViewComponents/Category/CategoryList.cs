using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        private readonly CategoryManager _categoryManager = new(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = _categoryManager.GetListAll();
            return View(values);
        }
    }
}