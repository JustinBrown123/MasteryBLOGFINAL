using MasteryBlog2.Model;
using MasteryBlog2.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasteryBlog2.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {

        private BlogContext db;

        public CategoryRepository(BlogContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Set<Category>().Count();
        }


        //public Category GetById(int id)
        //{
        //    return db.Set<Category>().Find(id);
        //}
        public Category GetById(int id)
        {
            return db.Categories.Single(b => b.Id == id);
        }



        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories;
        }

        public void Edit(Category blog)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<Category> GetByTagID(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Category obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
