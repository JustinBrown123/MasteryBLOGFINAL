using MasteryBlog2.Data;
using MasteryBlog2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog2.Repositories
{
    public class BlogRepository : IRepository<Blog>
    {
        private BlogContext db;

        public BlogRepository(BlogContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Blogs.Count();
        }


        public IEnumerable<Blog> GetAll()
        {
            return db.Blogs;
        }


        public Blog GetById(int id)
        {
            return db.Blogs.SingleOrDefault(b => b.Id == id);
        }


        public void Create(Blog blog)
        {
            db.Blogs.Add(blog);
            db.SaveChanges();
        }

        public void Delete(Blog blog)
        {
            db.Blogs.Remove(blog);
            db.SaveChanges();
        }

        public void Edit(Blog blog)
        {
            db.Blogs.Update(blog);
            db.SaveChanges();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Blog> GetByTagID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
