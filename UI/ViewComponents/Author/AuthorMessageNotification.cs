using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Author
{
    public class AuthorMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {            
            return View();
        }

    }
}