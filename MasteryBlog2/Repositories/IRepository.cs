using System.Collections.Generic;

namespace MasteryBlog2.Repositories
    {
        public interface IRepository<T> where T : class
        {
            IEnumerable<T> GetAll();

            T GetById(int id);
            void Create(T obj);
            void Delete(T obj);
            void Edit(T obj);
            IEnumerable<T> GetByTagId(int tagId);
        IEnumerable<T> GetByCategoryId(int categoryId);


    }

}