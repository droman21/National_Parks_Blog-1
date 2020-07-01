using Xunit;
using System;
using National_Park_Blog.Models;
using National_Park_Blog.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace National_Park_Blog.Tests
{
    public class ModelTests
    {
        National_Parks underTest;
        
        public ModelTests()
        {
            underTest = new National_Parks("Yellowstone", 1, "The best park", "", "Wyoming");
        }
        [Fact]
        public void NationalParkConstructor_Sets_Name_On_National_ParksModel()
        {
            var result = underTest.Name;

            Assert.Equal("Yellowstone", result);
        }

        [Fact]
        public void NationalParkConstructor_Sets_Id_On_National_ParksModel()
        {
            var result = underTest.Id;

            Assert.Equal(1, result);
        }
        [Fact]
        public void  NationalParkConstructor_Sets_Description_On_National_ParksModel()
        {
            var result = underTest.Description;

            Assert.Equal("The best park", result);
        }
    }
}