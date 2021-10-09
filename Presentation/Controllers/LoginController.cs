using System.Linq;
using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(Author author)
        {
            Context context = new Context();
            var dataValue = context.Authors.FirstOrDefault(x =>
                x.AuthorMail == author.AuthorMail && x.AuthorPassword == author.AuthorPassword);
            if (dataValue != null)
            {
                HttpContext.Session.SetString("username", author.AuthorMail);
                return RedirectToAction("Index", "Author");
            }
            else
            {
                return View();
            }
        }
    }
}