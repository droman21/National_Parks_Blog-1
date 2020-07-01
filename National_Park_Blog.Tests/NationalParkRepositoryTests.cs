using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using National_Park_Blog.Models;
using National_Park_Blog.Repositories;

namespace National_Park_Blog.Tests
{
    public class NationalParkRepositoryTests : IDisposable
    {
        private NationalParkContext db;
        private NationalParkRepository underTest;

        public NationalParkRepositoryTests()
        {
            db = new NationalParkContext();
            db.Database.BeginTransaction();
            underTest = new NationalParkRepository(db);
        }
        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }
        [Fact]
        public void Create_Increases_Count_By_1()
        {
            var currCount = underTest.Count();
            underTest.Create(new National_Parks() { Name = "name" });
            var count = underTest.Count();
            Assert.Equal(currCount + 1, count);
        }
        [Fact]
        public void Count_Starts_At_Four()
        {
            var count = underTest.Count();
            Assert.Equal(4, count);
        }
    }
}
