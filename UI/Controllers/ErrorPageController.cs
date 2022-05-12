using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class ErrorPageController:Controller
    {
        public IActionResult Error1(int code)
        {
            ViewBag.Code=code;
            return View();
        }
    }
}