using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog2.Model
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }

        public string Body { get; set; }
        public string Reviewer { get; set; }
        public DateTime DateTime { get; set; }

        public virtual IList<TagBlog> TagBlogs { get; set; }

        //public virtual ICollection<Tag> Tags { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        //public virtual ICollection<Category> Categories { get; set; }
        public Blog()
        {
        }

    }
}
