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
            modelbuilder.Entity<National_Parks>().HasData(
     

            new National_Parks("Black River Reservation", 1, "Impressive park, a natural beauty", "/images/Black_River_Reservation.jpg", "Ohio"),
            new National_Parks("Gallatin National Park", 2, "Gateway to Yellowstone National Park", "/images/Gallatin_Sign.jpg", "Montana"),
            new National_Parks("Glacier National Park", 3, "The Crown of the Continent", "Glacier_Park_Sign.jpg", "Montana"),
            new National_Parks("Rocky River Reservation", 4, "Totally Safe", "Rocky_River_Park.jpg", "Ohio")

               );

            modelbuilder.Entity<Blog_Content>().HasData(

            new Blog_Content("Ron", 1, "Not too far away, very relaxing, great park.", "06-18-2020", 1),
            new Blog_Content("Dan", 2, "Totally awesome, once in a lifetime experience", "06-18-2020", 2),
            new Blog_Content("Chuck", 3, "Ran into many blockers during the trip, a bear raided my campsite", "06-18-2020", 3),
            new Blog_Content("Tom", 4, "I became one with Nature, 10/10 would recommend", "06-18-2020", 4)
               );


        }
    }
}
