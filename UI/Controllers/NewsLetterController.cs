using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
namespace UI.Controllers
{
    public class NewsLetterController:Controller
    {
        NewsLetterManager newsLetterManager=new NewsLetterManager(new EfNewsLetterRepository());
        [HttpGet]
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.MailStatus=true;
            newsLetterManager.TAdd(newsLetter);
            return PartialView();
        }
    }
}