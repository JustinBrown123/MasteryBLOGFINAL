using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasteryBlog2.Model;
using MasteryBlog2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MasteryBlog2.Controllers
{
    public class TagController : Controller
    {

            IRepository<Tag> tagRepo;

            public TagController(IRepository<Tag> tagRepo)
            {
                this.tagRepo = tagRepo;
            }


            public ViewResult Index()
            {
                var model = tagRepo.GetAll();

                return View(model);
            }

            //public ViewResult Details(int id)
            //{
            //    var model = tagRepo.GetById(id);
            //    return View(model);
            //}
        }
    }
