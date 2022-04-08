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
        
        public void CategoryAdd(Category category)
        {
            categoryDAL.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            categoryDAL.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            categoryDAL.Update(category);
        }

        public Category GetById(int id)
        {
            return categoryDAL.GetById(id);
        }

        public List<Category> GetList()
        {
            return categoryDAL.GetListAll();
        }
    }
}