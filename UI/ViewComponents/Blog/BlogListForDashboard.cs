using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UI.ViewComponents.Category
{
    public class BlogListForDashboard :ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {            
            var values = blogManager.GetBlogListWithCategory();
            return View(values);
        }
    }
}