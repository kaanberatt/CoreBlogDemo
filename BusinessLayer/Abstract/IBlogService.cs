using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {
        void BlogAdd(Blog category);
        void BlogDelete(Blog category);
        void BlogUpdate(Blog category);
        List<Blog> GetList();
        Blog GetById(int id);
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListByAuthor(int id);
    }
}