using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDAL blogDAL;
        public BlogManager(IBlogDAL _blogDAL)
        {
            blogDAL = _blogDAL;
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return blogDAL.GetListWithCategory();
        }

        public List<Blog> GetBlogById(int id)
        {
            return blogDAL.GetListAll(x=>x.BlogId==id);
        }

        public List<Blog> GetLast3Blog()
        {
            return blogDAL.GetListAll().TakeLast(3).ToList();
        }

        
        public List<Blog> GetBlogListByAuthor(int id)
        {
            return blogDAL.GetListAll(x=>x.AuthorId==id,null, x=>x.Category);
        }

        public void TAdd(Blog t)
        {
            blogDAL.Insert(t);
        }

        public void TDelete(Blog t)
        {
            blogDAL.Delete(t);
        }

        public void TUpdate(Blog t)
        {
            blogDAL.Update(t);
        }

        public List<Blog> TGetList()
        {
            return blogDAL.GetListAll();
        }

        public Blog TGetById(int id)
        {
            return blogDAL.GetById(id);
        }
    }
}