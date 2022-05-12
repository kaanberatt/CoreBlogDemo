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
        public void ContactAdd(Contact contact)
        {
            contactDAL.Insert(contact);            
        }
    }
}