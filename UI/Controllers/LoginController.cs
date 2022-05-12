using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class LoginController:Controller
    {        
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Author author)
        {
            Context context=new Context();
            var datavalues = context.Authors.FirstOrDefault(x=>x.AuthorMail==author.AuthorMail && x.AuthorPassword==author.AuthorPassword);
            if (datavalues != null )
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,author.AuthorMail)
                };
                var userIdentity= new ClaimsIdentity(claims,"a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Author");                
            }
            else
            {
                ViewBag.message="E-Mail Adresiniz veya Parolanız hatalı lütfen tekrar deneyiniz";
                return View();
            }
        }
    }
}