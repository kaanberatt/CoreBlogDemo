using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IAuthorService : IGenericService<Author>
    {
        public List<Author> GetAuthorById(int id);
    }
}