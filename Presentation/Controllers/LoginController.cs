using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
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
        public async Task<IActionResult> Index(Author author)
        {
            // Context context = new Context();
            // var dataValue = context.Authors.FirstOrDefault(x =>
            //     x.AuthorMail == author.AuthorMail && x.AuthorPassword == author.AuthorPassword);
            // if (dataValue != null)
            // {
            //     HttpContext.Session.SetString("username", author.AuthorMail);
            //     return RedirectToAction("Index", "Author");
            // }
            //
            // return View();

            Context context = new Context();
            var dataValue = context.Authors.FirstOrDefault(x =>
                x.AuthorMail == author.AuthorMail && x.AuthorPassword == author.AuthorPassword);
            if (dataValue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, author.AuthorMail)
                };

                var userIndetity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIndetity);
                await HttpContext.SignInAsync(claimsPrincipal);
                
                return RedirectToAction("Index", "Author");
            }
            else
            {
                return View();
            }
        }
    }
}