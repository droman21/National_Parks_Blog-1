using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using National_Park_Blog.Models;
using National_Park_Blog.Repositories;
using Microsoft.EntityFrameworkCore;

namespace National_Park_Blog.Controllers
{
    public class Blog_Content_Controller : Controller
    {
        readonly IRepository<Blog_Content> blogContentRepo;

        public Blog_Content_Controller(IRepository<Blog_Content> blogContentRepo)
        {
            this.blogContentRepo = blogContentRepo;
        }
        public ViewResult Index()
        {
            var model = blogContentRepo.GetAll();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            var model = blogContentRepo.GetById(id);
            return View(model);
        }
        [HttpGet]
        public ViewResult CreateByNationalParkID(int Id)
        {
            ViewBag.NationalParkID = Id;
            return View();
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Blog_Content blog_Content)
        {

            if (ModelState.IsValid)
            {
                blog_Content.BlogContentDate = DateTime.Now;
                blogContentRepo.Create(blog_Content);
                return RedirectToAction("Details", "NationalParks", new { id = blog_Content.NationalParkId });
            }
            return View(blog_Content);
        }
        [HttpGet]
        public ViewResult Update(int id)
        {
            Blog_Content blogContent = blogContentRepo.GetById(id);
            return View(blogContent);
        }
        public object Count()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(Blog_Content blog_Content)
        {
            if (ModelState.IsValid)
            {
                blog_Content.BlogContentDate = DateTime.Now;
                blogContentRepo.Update(blog_Content);
                return RedirectToAction("Details", "NationalParks", new { id = blog_Content.NationalParkId });

            }
            return View(blog_Content);
        }
        [HttpGet]
        public ViewResult Delete(int id)
        {
            Blog_Content blog_Content = blogContentRepo.GetById(id);
            return View(blog_Content);
        }
        [HttpPost]
        public ActionResult Delete(Blog_Content blog_Content)
        {
                int nationalParkId = blog_Content.NationalParkId;
                blogContentRepo.Delete(blog_Content);
                return RedirectToAction("Details", "NationalParks", new { id = nationalParkId });
        }
    }
}
