using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Category
{
    public class AuthorLatestBlog:ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {            
            var values = blogManager.GetBlogListByAuthor(3);
            return View(values);
        }
    }
}