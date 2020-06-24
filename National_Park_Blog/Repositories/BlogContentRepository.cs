using National_Park_Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace National_Park_Blog.Repositories
{
    public class BlogContentRepository : IRepository<Blog_Content>
    {
            private readonly NationalParkContext db;
            public BlogContentRepository(NationalParkContext db)
            {
                this.db = db;
            }
            public IEnumerable<Blog_Content> GetAll()
            {
                return db.BlogContent;
            }
            public Blog_Content GetById(int id)
            {
                return db.BlogContent.Single(c => c.Id == id);
            }
            public int Count()
            {
                return db.BlogContent.Count();
            }
            public void Create(Blog_Content blogContent)
            {
                db.BlogContent.Add(blogContent);
                db.SaveChanges();
            }
            public void Delete(Blog_Content blogContent)
            {
                db.BlogContent.Remove(blogContent);
                db.SaveChanges();
            }
            public void Update(Blog_Content blog_Content)
            {
                db.BlogContent.Update(blog_Content);
                db.SaveChanges();
            }
            IEnumerable<Blog_Content> IRepository<Blog_Content>.GetAll()
            {
                throw new NotImplementedException();
            }

            Blog_Content IRepository<Blog_Content>.GetById(int id)
            {
                throw new NotImplementedException();
            }
    }
}

