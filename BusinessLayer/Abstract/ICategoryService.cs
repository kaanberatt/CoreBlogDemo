using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    // BusinessLayer Katmanında Abstract içerisindeki interface'ler Service olarak tanımlanır.
    public interface ICategoryService
    {
        void CategoryAdd(Category category);
        void CategoryDelete(Category category);
        void CategoryUpdate(Category category);
        List<Category> GetList();
        Category GetById(int id);
    }
}