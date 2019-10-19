using MasteryBlog2.Model;
using MasteryBlog2.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog2.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {

        private DbContext db;

        public CategoryRepository(DbContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Set<Category>().Count();
        }

        public void Create(Category entity)
        {
            db.Set<Category>().Add(entity);
            db.SaveChanges();
        }

        public Category GetById(int id)
        {
            return db.Set<Category>().Find(id);
        }

        public void Delete(Category entity)
        {
            db.Set<Category>().Remove(entity);
            db.SaveChanges();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Set<Category>().ToList();
        }

        public void Edit(Category blog)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Category> GetByTagID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
