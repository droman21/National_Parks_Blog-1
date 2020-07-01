using System;
using System.Collections.Generic;
using Xunit;
using National_Park_Blog.Controllers;
using Microsoft.AspNetCore.Mvc;
using National_Park_Blog.Models;
using National_Park_Blog.Repositories;
using NSubstitute;

namespace National_Park_Blog.Tests
{
    public class NationalParksControllerTests
    {
        public NationalParksController underTest;
        IRepository<National_Parks> natRepo;

        public NationalParksControllerTests()
        {
            natRepo = Substitute.For<IRepository<National_Parks>>();
            underTest = new NationalParksController(natRepo);
        }

        [Fact]
        public void Index_Returns_View()
        {

            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Index_Passes_All_Parks_to_View()
        {
            var parklist = new List<National_Parks>();
            natRepo.GetAll().Returns(parklist);
            var result = underTest.Index();
            Assert.Equal(parklist, result.Model);
        }
    }
}
