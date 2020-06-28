﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using National_Park_Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace National_Park_Blog.Repositories
{
    public class NationalParkRepository : IRepository<National_Parks>
    {
        private NationalParkContext db;
        public NationalParkRepository(NationalParkContext db)
        {
            this.db = db;
        }
        public void Create(National_Parks nationalpark)
        {
            db.NationalParks.Add(nationalpark);
            db.SaveChanges();
        }
        public void Delete(Blog_Content blogContent)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<National_Parks> GetAll()
        {
            return db.NationalParks.ToList();
        }
        public National_Parks GetById(int id)
        {
            return db.NationalParks.Single(c => c.Id == id);
        }
        public int Count()
        {
            return db.NationalParks.Count();
        }
        public void Update(Blog_Content review)
        {
            throw new NotImplementedException();
        }
    }
}
