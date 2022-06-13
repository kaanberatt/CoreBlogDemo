using System;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = blogManager.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            ViewBag.Id_value = id;
            var values = blogManager.GetBlogById(id);
            ViewBag.AuthorId = values[0].AuthorId;
            return View(values);
        }
        public IActionResult BlogListByAuthor()
        {
            var values = blogManager.GetBlogListByAuthor(3);
            return View(values);
        }
        [HttpGet]
        public IActionResult BlogAdd()
        {
            BlogVm blogVm = new BlogVm()
            {
                Categories = categoryManager.TGetList()
            };
            return View(blogVm);
        }
        [HttpPost]
        public IActionResult BlogAdd(BlogVm blogvm)
        {
            BlogValidator blogValidator = new BlogValidator();
            ValidationResult result = blogValidator.Validate(blogvm.Blog);
            if (result.IsValid)
            {
                blogvm.Blog.BlogStatus = true;
                blogvm.Blog.CreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                blogvm.Blog.AuthorId = 3;
                blogManager.TAdd(blogvm.Blog);
                return RedirectToAction("BlogListByAuthor", "Blog");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult BlogEdit(int id)
        {
            BlogVm blogVm = new BlogVm()
            {
                Blog = blogManager.TGetById(id),
                Categories = categoryManager.TGetList()
            };
            return View(blogVm);
        }
        [HttpPost]
        public IActionResult BlogEdit(BlogVm blogvm)
        {
            BlogValidator blogValidator = new BlogValidator();
            ValidationResult result = blogValidator.Validate(blogvm.Blog);
            if (result.IsValid)
            {
                blogManager.TUpdate(blogvm.Blog);
                return RedirectToAction("BlogListByAuthor", "Blog");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
                }
            }
            return View();
        }
        public RedirectToActionResult BlogRemove(int id)
        {
            var blogValues = blogManager.TGetById(id);
            blogManager.TDelete(blogValues);
            return RedirectToAction("BlogListByAuthor", "Blog");
        }
        // public PartialViewResult BlogLast3Post()
        // {
        //     var values = blogManager.GetLast3Blog();
        //     return PartialView(values);
        // }
    }
}