using System.Collections.Generic;
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
        public void BlogAdd(Blog blog)
        {
            blogDAL.Insert(blog);
        }

        public void BlogDelete(Blog blog)
        {
            blogDAL.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            blogDAL.Update(blog);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return blogDAL.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            return blogDAL.GetById(id);
        }
        public List<Blog> GetBlogById(int id)
        {
            return blogDAL.GetListAll(x=>x.BlogId==id);
        }

        public List<Blog> GetList()
        {
            return blogDAL.GetListAll();
        }
        

        public List<Blog> GetBlogListByAuthor(int id)
        {
            return blogDAL.GetListAll(x=>x.AuthorId==id);
        }
    }
}