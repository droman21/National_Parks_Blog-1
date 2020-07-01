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

    }
}
