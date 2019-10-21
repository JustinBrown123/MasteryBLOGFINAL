using MasteryBlog2.Controllers;
using MasteryBlog2.Model;
using MasteryBlog2.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace MasteryBlog2.Tests
{
    public class BlogControllerTests
    {
        BlogController underTest;
        IRepository<Blog> coffeeRepo;

        public BlogControllerTests()
        {
            coffeeRepo = Substitute.For<IRepository<Blog>>();
            underTest = new BlogController(coffeeRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Blogs_To_View()
        {
            var expectedBlog = new List<Blog>();
            coffeeRepo.GetAll().Returns(expectedBlog);

            var result = underTest.Index();

            Assert.Equal(expectedBlog, result.Model);
        }

     
    }
}
