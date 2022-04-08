using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal newsLetterDal;
        public NewsLetterManager(INewsLetterDal _newsLetterDal)
        {
            newsLetterDal = _newsLetterDal;
        }
        public void AddNewsLetter(NewsLetter newsLetter)
        {
            newsLetterDal.Insert(newsLetter);
        }
    }
}