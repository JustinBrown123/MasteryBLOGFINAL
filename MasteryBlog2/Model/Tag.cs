using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog2.Model
{
    public class Tag
    {
            public int Id { get; set; }

            public string Content { get; set; }

            public virtual IList<TagBlog> TagBlogs { get; set; }

            public Tag()
            {

            }

            public Tag(int id, string content)
            {
                Id = id;
                Content = content;
            }
        }
    }

