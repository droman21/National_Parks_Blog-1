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
    public class NationalParksController : Controller
    {
        IRepository<National_Parks> natRepo;

        public NationalParksController(IRepository<National_Parks> natRepo)
        {
            this.natRepo = natRepo;
        }
        public NationalParksController()
        {
        }
        public ViewResult Index()
        {
            var model = natRepo.GetAll();
            return View(model);
        }
        public ViewResult Details(int id)
        {
            var model = this.natRepo.GetById(id);
            return View(model);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public Microsoft.AspNetCore.Mvc.ActionResult Create(National_Parks nationalPark)
        {
            if (ModelState.IsValid)
            {
                natRepo.Create(nationalPark);
                return RedirectToAction("Index");
            }
            return View(nationalPark);
        }
        public void Delete(Blog_Content blog_Content)
        {
            throw new NotImplementedException();
        }
        public ActionResult Update(Blog_Content blog_Content)
        {
            if (ModelState.IsValid)
            {
                blog_Content.BlogContentDate = DateTime.Now;
                int nationalParkId = blog_Content.NationalParkId;
                natRepo.Update(blog_Content);
                return RedirectToAction("Details", "NationalParks", new { id = nationalParkId });

            }
            return View(blog_Content);
        }
    }
}
