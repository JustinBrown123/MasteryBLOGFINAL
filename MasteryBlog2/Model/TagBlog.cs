using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog2.Model
{
    public class TagBlog
    {
        public int BlogId { get; set; }
        public virtual Blog Blogs { get; set; }

        public int TagId { get; set; }
        public virtual Tag Tags { get; set; }

    }
}
