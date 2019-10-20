using MasteryBlog2.Data;
using MasteryBlog2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog2.Repositories
{
    public class TagRepository : IRepository<Tag>
    {

        private BlogContext db;

        public TagRepository(BlogContext db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Set<Tag>().Count();
        }

        public void Create(Tag entity)
        {
            db.Set<Tag>().Add(entity);
            db.SaveChanges();
        }

        public Tag GetById(int id)
        {
            return db.Set<Tag>().Find(id);
        }

        public void Delete(Tag entity)
        {
            db.Set<Tag>().Remove(entity);
            db.SaveChanges();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Tag> GetAll()
        {
            return db.Set<Tag>().ToList();
        }

        public void Edit(Tag blog)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Tag> GetByTagId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
