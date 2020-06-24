using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using National_Park_Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace National_Park_Blog
{
    public class NationalParkContext : DbContext
    {
        public DbSet<National_Parks> NationalParks { get; set; }
        public DbSet<Blog_Content> BlogContent { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=GolfCourseDatabase;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            //modelbuilder.Entity<National_Parks>().HasData(


            //   new GolfCourse("Bushwood CC", 1, "Good snack shack and poor caddying", "Bushwood.jpg", "18Hole"),
            //   new GolfCourse("Fury Creek Golf CC", 2, "Price is wrong B&$#%", "FurryCreek.jpg", "PuttPutt"),
            //   new GolfCourse("Cotton Wood", 3, "Waggle and let the big dog eat", "Cottonwood.jpg", "9Hole"),
            //   new GolfCourse("Little Met", 4, "Great course for beginners, not so much for the advanced player", "golfcouse5.jpg", "Par3")

            //   );

            //modelbuilder.Entity<Blog_Content>().HasData(

            //   new Review("Ron", 1, "I played bad. This course sucks.", "06-18-2020", 1, 1),
            //   new Review("Dan", 2, "I played good. This course is awesome.", "06-18-2020", 2, 1),
            //   new Review("Chuck", 3, "I'm a pro, and wouldn't play a crappy course like this.", "06-18-2020", 3, 2),
            //   new Review("Tom", 4, "I forgot my clubs and didn't actually play.", "06-18-2020", 4, 1)
            //   );


        }
    }
}
