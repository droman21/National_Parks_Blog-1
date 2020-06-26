using Xunit;
using System;
using National_Park_Blog.Models;
using National_Park_Blog.Controllers;

namespace National_Park_Blog.Tests
{
    public class ModelTests
    {
        ModelTests underTest;
        
        public ModelTests()
        {
            underTest = new National_Parks("Yellowstone", 1, "The best park", "");
        }
        [Fact]
        public void Get_Name_Returns_Name()
        {
            var underTest = new National_Parks();
            string result = underTest.Name;
            Assert.Equal("Yellowstone", result);
        }

        public static implicit operator ModelTests(National_Parks v)
        {
            throw new NotImplementedException();
        }
    }
}