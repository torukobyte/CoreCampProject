using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        [AllowAnonymous]
        public PartialViewResult AuthorSidebarPartial()
        {
            return PartialView();
        }
        
        [AllowAnonymous]
        public PartialViewResult AuthorFooterPartial()
        {
            return PartialView();
        }
    }
}