using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDAL contactDAL;
        public ContactManager(IContactDAL _contactDAL)
        {
            contactDAL=_contactDAL;
        }
        public void TAdd(Contact t)
        {
            contactDAL.Insert(t);   
        }

        public void TDelete(Contact t)
        {
            throw new System.NotImplementedException();
        }

        public Contact TGetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Contact> TGetList()
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            throw new System.NotImplementedException();
        }
    }
}