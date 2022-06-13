using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Author
{
    public class AuthorNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {            
            return View();
        }
    }
}