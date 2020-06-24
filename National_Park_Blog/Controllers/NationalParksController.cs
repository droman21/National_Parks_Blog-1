using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using National_Park_Blog.Models;
using National_Park_Blog.Repositories;

namespace National_Park_Blog.Controllers
{
    public class NationalParksController : Controller
    {
        IRepository<National_Parks> natRepo;

        public NationalParksController(IRepository<National_Parks> natRepo)
        {
            this.natRepo = natRepo;
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
    }
}
