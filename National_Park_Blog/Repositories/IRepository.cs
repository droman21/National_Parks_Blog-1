using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using National_Park_Blog.Models;


namespace National_Park_Blog.Repositories
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T obj);
        void Delete(Blog_Content blogContent);
        void Update(Blog_Content review);
    }
}
