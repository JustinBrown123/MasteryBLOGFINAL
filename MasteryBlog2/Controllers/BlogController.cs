using MasteryBlog2.Model;
using MasteryBlog2.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog2.Controllers
{
    public class BlogController : Controller
    {
        IRepository<Blog> blogRepo;

        public BlogController(IRepository<Blog> blogRepo)
        {
            this.blogRepo = blogRepo;
        }

        public ViewResult Index()
        {
            var model = blogRepo.GetAll();
            return View(model);
        }
        public ViewResult GetByCategoryId(int id)
        {
            var model = blogRepo.GetById(id);

            return View(model);
        }

        public ViewResult BlogByTagId(int id)
        {
            var model = blogRepo.GetByTagId(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Blog blog)
        {
            blog.DateTime = DateTime.Now;
            blogRepo.Create(blog);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Blog blog)
        {
            blogRepo.Delete(blog);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = blogRepo.GetById(id);
            return View(model);
        }

        //[HttpPost]
        //public ActionResult Edit(Blog blog)
        //{
        //    blog.DateTime = DateTime.Now;
        //    blogRepo.Edit(blog);
        //    return RedirectToAction("Index");
        //}

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = blogRepo.GetById(id);
            return View(model);
        }

    }


}

