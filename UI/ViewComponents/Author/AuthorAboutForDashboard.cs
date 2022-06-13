using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Author
{
    public class AuthorAboutForDashboard : ViewComponent
    {
        AuthorManager authorManager = new AuthorManager(new EfAuthorRepository());
        public IViewComponentResult Invoke()
        {   
            var values = authorManager.GetAuthorById(3);         
            return View(values);
        }

    }
}