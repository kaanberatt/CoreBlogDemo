using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{   
    public class AuthorManager : IAuthorService
    {
        IAuthorDAL authorDAL;
        public AuthorManager(IAuthorDAL _authorDAL)
        {
            authorDAL=_authorDAL;
        }
        public void AuthorAdd(Author author)
        {
            authorDAL.Insert(author);
        }
    }
}