using MasteryBlog2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasteryBlog2.Data
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagBlog> TagBlogs { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogTwoTesting;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TagBlog>().HasKey(sc => new { sc.BlogId, sc.TagId });

            modelBuilder.Entity<Blog>().HasData(
                        new Blog()
                        {
                            Id = 1,
                            Image = "/Images/LordOfTheRings.jpg",
                            Title = "The Lord of the Rings",
                            CategoryId = 1,
                            Body = "Seriously it is the best freaking book I've ever read .and I'm not the type of a person who always reads books, I like movies more, still the movie is absolutely breathtaking so as the book, and if I have to compare the movie to the book I would definitely choose the book. I highly recommended.",
                            Reviewer = "LEGOLAS_IS_NOT_DED"
                        },

                        new Blog()
                        {
                            Id = 2,
                            Image = "/Images/TheHobbit.jpg",
                            Title = "The Hobbit",
                            CategoryId = 1,
                            Body = "There are few worlds more richly imagined than Tolkien's Middle Earth. Readers would get caught up just in his exquisitely imaginative details if it weren't for the nonstop adventure; it's a perfect balance. Add to that a wonderful main character -- the hairy-footed little hobbit who truly triumphs -- and you have the perfect fantasy-adventure. This is how it's done.",
                            Reviewer = "Aragorn-4ever-XSlayerX"
                        },
                    new Blog()
                    {
                        Id = 3,
                        Image = "/Images/FiftyShadesGrey.jpg",
                        Title = "Fifty Shades of Grey",
                        CategoryId = 2,
                        Body = "Given what I'd heard about this book I expected it to be poorly written and salacious. I had never intended to read it for those reasons. But with the movie out this weekend, I can't walk two feet without having this book in my face. I decided I needed to read it, so I would truly know what all the fuss was about. What surprised me was how boring it was. There was no plot and the dialogue was silly. Also, with all the talk about this book, I expected it to be sexy to the point of scandalous. I didn't find it sexy at all and certainly not romantic. When all is said and done, it's not the subject matter that I find offensive. It's the bad writing.",
                        Reviewer = "Not Justin Brown"
                    },

                    new Blog()
                    {
                        Id = 4,
                        Image = "/Images/FiftyShadesDarker.jpg",
                        Title = "Fifty Shades Darker",
                        CategoryId = 2,
                        Body = "This trilogy is a guilty pleasure, no doubt about it. It is not a literary work of art. It is not a challenging read. Much of the story is predictable. Some parts are cheesy. That being said, it's an addicting story one step above a $5 romance novel and I'm not ashamed to say I enjoyed it.",
                        Reviewer = "Maybe Justin Brown"
                    },

                    new Blog()
                    {
                        Id = 5,
                        Image = "/Images/FiftyShadesFreed.jpg",
                        Title = "Fifty Shades Freed",
                        CategoryId = 2,
                        Body = "I have become enticed by these characters and their story. The kinky stuff was interesting to read but I really enjoyed the characters. Their conflict, different personalities, sharing and becoming one in marriage. There is more to the story then the sex and that I enjoyed greatly. I love how Anna loves and helps Christian to become a better himself. Then again the way Christian pushes Anna to be bolder and more attentive is really inspiring. Their love story, yes kinky and out of the normal, is what I wish to accomplish. The partnership, trust, and growth I want in my relationship. I will see about getting my love to read this and maybe I will.",
                        Reviewer = "Definitely Justin Brown"
                    });


   
            modelBuilder.Entity<Tag>().HasData(
             new Tag()
             {
                 Id = 1,
                 Content = "Enjoyable Reading"

             },
              new Tag()
              {
                  Id = 2,
                  Content = "Innapropriate Reading"

              }
             );

            modelBuilder.Entity<Category>().HasData(
            new Category()
            {
                Id = 1,
                Genre = "Fantasy",
            },
            new Category()     
            {
                Id = 2,
                Genre = "Adult",
            },
            new Category()
            {
                Id = 3,
                Genre = "Horror",
            },
             new Category()
             {
                 Id = 4,
                 Genre = "Sci-Fi",
             },
              new Category()
              {
                  Id = 5,
                  Genre = "Non-Fiction",
              }

            );
            modelBuilder.Entity<TagBlog>().HasData(
            new TagBlog()
             {
                BlogId = 1,
                TagId = 1,
             },
            new TagBlog()
             {
                BlogId = 2,
                TagId = 1,
             },
            new TagBlog()
             {
                BlogId = 3,
                TagId = 2,
             },
            new TagBlog()
            {
                BlogId = 4,
                TagId = 2,
            },
            new TagBlog()
            {
                BlogId = 5,
                TagId = 2,
            }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
