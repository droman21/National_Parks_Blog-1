using System;
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
        public void Create(National_Park obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog_Content blogContent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<National_Parks> GetAll()
        {
            return .Nat;
        }

        public National_Parks GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Blog_Content review)
        {
            throw new NotImplementedException();
        }
    }
}
