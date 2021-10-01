using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;

namespace Presentation.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var values = new List<UserComment>
            {
                new()
                {
                    ID = 1,
                    username = "Burak"
                },
                new()
                {
                    ID = 2,
                    username = "torukobyte"
                }
            };

            return View(values);
        }
    }
}