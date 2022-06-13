using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    // BusinessLayer Katmanında concrete içerisindeki classlar Manager olarak tanımlanır.
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL categoryDAL;
        public CategoryManager(ICategoryDAL _categoryDAL)
        {
            categoryDAL = _categoryDAL;
        }
        
         public void TAdd(Category t)
        {
            categoryDAL.Insert(t);
        }

        public void TDelete(Category t)
        {
            categoryDAL.Delete(t);
        }

        public void TUpdate(Category t)
        {
            categoryDAL.Update(t);
        }

        public List<Category> TGetList()
        {
            return categoryDAL.GetListAll();
        }

        public Category TGetById(int id)
        {
            return categoryDAL.GetById(id);
        }
    }
}