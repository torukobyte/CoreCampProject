using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class RegisterController : Controller
    {
        private readonly AuthorManager authorManager = new(new EfAuthorRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Author author)
        {
            var authorValidator = new AuthorValidator();
            var result = authorValidator.Validate(author);

            if (result.IsValid)
            {
                author.AuthorStatus = true;
                author.AuthorAbout = "test";
                authorManager.AddAuthor(author);
                return RedirectToAction("Index", "Blog");
            }

            foreach (var item in result.Errors) ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

            return View();
        }
    }
}