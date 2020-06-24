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
        ControllerTests underTest;
        public ControllerTests()
        {
            //underTest = new NationalParksController();
        }
        [Fact]
        public void Index_Returns_ViewResult()
        {
            //var result = underTest.Index();
            //Assert.IsType <ViewResult>(result);
        }
        [Fact]
        public void Index_Passes_National_Parks_Model_Is_view()
        {
            //var underTest = new NationalParksController();
            //var result = underTest.Index();
            //Assert.IsType <National_Park_Blog.Models.National_Parks>(result.Model);
        }
    }
}
