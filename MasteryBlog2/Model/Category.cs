using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog2.Model
{
    public class Category
    {

        public int Id { get; set; }

        public string Genre { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }

        //public virtual Blog Blogs { get; set; }

        public Category()
        {

        }

        public Category(int id, string genre)
        {
            Id = id;
            Genre = genre;
        }

    }
}
