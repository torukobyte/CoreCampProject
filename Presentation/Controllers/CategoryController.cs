using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class CategoryController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}