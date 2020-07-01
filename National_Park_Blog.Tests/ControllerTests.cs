using System;
using System.Collections.Generic;
using Xunit;
using National_Park_Blog.Controllers;
using Microsoft.AspNetCore.Mvc;
using National_Park_Blog.Models;

namespace National_Park_Blog.Tests
{
    public class ControllerTests
    {
        private NationalParksController underTest;
        public ControllerTests()
        {
            underTest = new NationalParksController();
        }
        [Fact]
        public void Index_Returns_View()
        {
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }

        //private object Index()
        //{
        //    throw new NotImplementedException();
        //}

        [Fact]
        public void Index_Passes_National_Parks_Model_to_view()
        {
            var result = underTest.Index();
            Assert.IsType <List<National_Parks>>(result.Model);
        }
    }
}
