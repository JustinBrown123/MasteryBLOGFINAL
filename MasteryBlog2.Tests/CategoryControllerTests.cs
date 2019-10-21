using MasteryBlog2.Controllers;
using MasteryBlog2.Model;
using MasteryBlog2.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MasteryBlog2.Tests
{
    public class CategoryControllerTests
    {
        CategoryController underTest;
        IRepository<Category> coffeeRepo;

        public CategoryControllerTests()
        {
            coffeeRepo = Substitute.For<IRepository<Category>>();
            underTest = new CategoryController(coffeeRepo);
        }

        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Category_To_View()
        {
            var expectedCategory = new List<Category>();
            coffeeRepo.GetAll().Returns(expectedCategory);

            var result = underTest.Index();

            Assert.Equal(expectedCategory, result.Model);
        }

        [Fact]
        public void GetByCategoryId_Returns_A_View()
        {
            var result = underTest.GetByCategoryId(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void GetByCategoryId_Passes_Course_To_View()
        {
            var expectedCategory = new Category();
            coffeeRepo.GetById(1).Returns(expectedCategory);

            var result = underTest.GetByCategoryId(1);

            Assert.Equal(expectedCategory, result.Model);
        }

    }
}
