using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDAL aboutDAl;
        public AboutManager(IAboutDAL _aboutDAL)
        {
            aboutDAl=_aboutDAL;
        }

        public List<About> TGetList()
        {
            return aboutDAl.GetListAll();
        }
        public void TAdd(About t)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(About t)
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(About t)
        {
            throw new System.NotImplementedException();
        }

        

        public About TGetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}