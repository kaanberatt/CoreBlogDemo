using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class RegisterController : Controller
    {
        AuthorManager authorManager = new AuthorManager(new EfAuthorRepository());

        [HttpGet] //sayfa yüklenince
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] // sayfada buton tetiklenince
        public IActionResult Index(Author _author)
        {
            AuthorValidator authorValidator = new AuthorValidator();
            ValidationResult result = authorValidator.Validate(_author);
            if (result.IsValid)
            {
                _author.AuthorStatus = true;
                _author.AuthorAbout = "Deneme Test";
                authorManager.AuthorAdd(_author);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName,error.ErrorMessage);
                }
            }
            return View();
        }
    }
}