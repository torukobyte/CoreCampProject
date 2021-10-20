using Microsoft.AspNetCore.Mvc;

namespace Presentation.ViewComponents.Author
{
    public class AuthorNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}