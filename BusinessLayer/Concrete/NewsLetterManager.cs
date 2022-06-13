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

        public void TAdd(NewsLetter t)
        {
            newsLetterDal.Insert(t);
        }

        public void TDelete(NewsLetter t)
        {
            throw new System.NotImplementedException();
        }

        public NewsLetter TGetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<NewsLetter> TGetList()
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(NewsLetter t)
        {
            throw new System.NotImplementedException();
        }
    }
}