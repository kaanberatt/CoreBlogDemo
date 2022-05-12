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
        public List<About> GetList()
        {   
            return aboutDAl.GetListAll();
        }
    }
}