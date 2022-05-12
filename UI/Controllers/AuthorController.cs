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
        
    }
}