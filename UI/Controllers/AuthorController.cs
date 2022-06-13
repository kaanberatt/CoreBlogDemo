using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class AuthorController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AuthorProfile()
        {
            return View();
        }
        public IActionResult AuthorMail()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        public PartialViewResult AuthorNavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult AuthorFooterPartial()
        {
            return PartialView();
        }        
    }
}