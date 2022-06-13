using System.Collections.Generic;
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

        public List<Author> GetAuthorById(int id)
        {
            return authorDAL.GetListAll(x=>x.AuthorId==id);
        }

        public void TAdd(Author t)
        {
             authorDAL.Insert(t);
        }

        public void TDelete(Author t)
        {
            throw new System.NotImplementedException();
        }

        public Author TGetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Author> TGetList()
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(Author t)
        {
            throw new System.NotImplementedException();
        }
    }
}