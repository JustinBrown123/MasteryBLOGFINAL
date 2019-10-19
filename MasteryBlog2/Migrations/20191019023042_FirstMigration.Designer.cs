﻿// <auto-generated />
using System;
using MasteryBlog2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MasteryBlog2.Migrations
{
    [DbContext(typeof(BlogContext))]
    [Migration("20191019023042_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MasteryBlog2.Model.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Image");

                    b.Property<string>("Reviewer");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Blogs");

                    b.HasData(
                        new { Id = 1, Body = "Seriously it is the best freaking book I've ever read .and I'm not the type of a person who always reads books, I like movies more, still the movie is absolutely breathtaking so as the book, and if I have to compare the movie to the book I would definitely choose the book. I highly recommended.", CategoryId = 1, DateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Image = "/Images/LordOfTheRings.jpg", Reviewer = "LEGOLAS_IS_NOT_DED", Title = "The Lord of the Rings" },
                        new { Id = 2, Body = "There are few worlds more richly imagined than Tolkien's Middle Earth. Readers would get caught up just in his exquisitely imaginative details if it weren't for the nonstop adventure; it's a perfect balance. Add to that a wonderful main character -- the hairy-footed little hobbit who truly triumphs -- and you have the perfect fantasy-adventure. This is how it's done.", CategoryId = 1, DateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Image = "/Images/TheHobbit.jpg", Reviewer = "Aragorn-4ever-XSlayerX", Title = "The Hobbit" },
                        new { Id = 3, Body = "Given what I'd heard about this book I expected it to be poorly written and salacious. I had never intended to read it for those reasons. But with the movie out this weekend, I can't walk two feet without having this book in my face. I decided I needed to read it, so I would truly know what all the fuss was about. What surprised me was how boring it was. There was no plot and the dialogue was silly. Also, with all the talk about this book, I expected it to be sexy to the point of scandalous. I didn't find it sexy at all and certainly not romantic. When all is said and done, it's not the subject matter that I find offensive. It's the bad writing.", CategoryId = 2, DateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Image = "/Images/FiftyShadesGrey.jpg", Reviewer = "Not Justin Brown", Title = "Fifty Shades of Grey" },
                        new { Id = 4, Body = "This trilogy is a guilty pleasure, no doubt about it. It is not a literary work of art. It is not a challenging read. Much of the story is predictable. Some parts are cheesy. That being said, it's an addicting story one step above a $5 romance novel and I'm not ashamed to say I enjoyed it.", CategoryId = 2, DateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Image = "/Images/FiftyShadesDarker.jpg", Reviewer = "Maybe Justin Brown", Title = "Fifty Shades Darker" },
                        new { Id = 5, Body = "I have become enticed by these characters and their story. The kinky stuff was interesting to read but I really enjoyed the characters. Their conflict, different personalities, sharing and becoming one in marriage. There is more to the story then the sex and that I enjoyed greatly. I love how Anna loves and helps Christian to become a better himself. Then again the way Christian pushes Anna to be bolder and more attentive is really inspiring. Their love story, yes kinky and out of the normal, is what I wish to accomplish. The partnership, trust, and growth I want in my relationship. I will see about getting my love to read this and maybe I will.", CategoryId = 2, DateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Image = "/Images/FiftyShadesFreed.jpg", Reviewer = "Definitely Justin Brown", Title = "Fifty Shades Freed" }
                    );
                });

            modelBuilder.Entity("MasteryBlog2.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genre");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new { Id = 1, Genre = "Fantasy" },
                        new { Id = 2, Genre = "Erotica" }
                    );
                });

            modelBuilder.Entity("MasteryBlog2.Model.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new { Id = 1, Content = "Enjoyable Reading" },
                        new { Id = 2, Content = "Innapropriate Reading" }
                    );
                });

            modelBuilder.Entity("MasteryBlog2.Model.TagBlog", b =>
                {
                    b.Property<int>("BlogId");

                    b.Property<int>("TagId");

                    b.HasKey("BlogId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("TagBlogs");

                    b.HasData(
                        new { BlogId = 1, TagId = 1 },
                        new { BlogId = 2, TagId = 1 },
                        new { BlogId = 3, TagId = 2 },
                        new { BlogId = 4, TagId = 2 },
                        new { BlogId = 5, TagId = 2 }
                    );
                });

            modelBuilder.Entity("MasteryBlog2.Model.Blog", b =>
                {
                    b.HasOne("MasteryBlog2.Model.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MasteryBlog2.Model.TagBlog", b =>
                {
                    b.HasOne("MasteryBlog2.Model.Blog", "Blogs")
                        .WithMany("TagBlogs")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MasteryBlog2.Model.Tag", "Tags")
                        .WithMany("TagBlogs")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}