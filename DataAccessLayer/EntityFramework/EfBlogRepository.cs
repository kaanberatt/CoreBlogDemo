using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository: GenericRepository<Blog>,IBlogDAL
    {
        public List<Blog> GetListWithCategory()
        {
            using (var context = new Context())
            {
                return context.Blogs.Include(x=>x.Category).ToList();
            }
        }
    }
}