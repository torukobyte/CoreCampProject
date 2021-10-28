using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.Category
{
    public class CategoryListDashboard:ViewComponent
    {
        private readonly CategoryManager _categoryManager = new(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = _categoryManager.GetList();
            return View(values);
        }
        
    }
}