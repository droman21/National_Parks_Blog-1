using National_Park_Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NSubstitute;
using National_Park_Blog.Models;
using National_Park_Blog.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace National_Park_Blog.Tests
{
    public class BlogContentControllerTests
    {
        public Blog_Content_Controller underTest;
        IRepository<Blog_Content> blogRepo;

        public BlogContentControllerTests()
        {
            blogRepo = Substitute.For<IRepository<Blog_Content>>();
            underTest = new Blog_Content_Controller(blogRepo);
        }
        [Fact]
        public void Index_Returns_View()
        {
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Details_Returns_View()
        {
            var result = underTest.Details(2);
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Details_Returns_Content_to_View()
        {
            var detailscontent = new Blog_Content();
            blogRepo.GetById(3).Returns(detailscontent);
            var result = underTest.Details(3);
            Assert.Equal(detailscontent, result.Model);
        }
        [Fact]
        public void CreateByNationalParkID_Returns_View()
        {
            var result = underTest.Create();
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Delete_Removes_Content()
        {
            var blogContent = new Blog_Content() { BlogContentName = "New Post" };
            underTest.Create(blogContent);

            underTest.Delete(blogContent);
            blogRepo.Received().Delete(blogContent);
        }


    }

}
