using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class AuthorController : Controller
    {
        [Authorize]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}