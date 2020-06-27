﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using National_Park_Blog;

namespace National_Park_Blog.Migrations
{
    [DbContext(typeof(NationalParkContext))]
    [Migration("20200626180500_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("National_Park_Blog.Models.Blog_Content", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlogContentDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogContentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlogContentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NationalParkId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NationalParkId");

                    b.ToTable("BlogContent");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlogContentDate = "06-18-2020",
                            BlogContentName = "Ron",
                            BlogContentText = "Not too far away, very relaxing, great park.",
                            NationalParkId = 1
                        },
                        new
                        {
                            Id = 2,
                            BlogContentDate = "06-18-2020",
                            BlogContentName = "Dan",
                            BlogContentText = "Totally awesome, once in a lifetime experience",
                            NationalParkId = 2
                        },
                        new
                        {
                            Id = 3,
                            BlogContentDate = "06-18-2020",
                            BlogContentName = "Chuck",
                            BlogContentText = "Ran into many blockers during the trip, a bear raided my campsite",
                            NationalParkId = 3
                        },
                        new
                        {
                            Id = 4,
                            BlogContentDate = "06-18-2020",
                            BlogContentName = "Tom",
                            BlogContentText = "I became one with Nature, 10/10 would recommend",
                            NationalParkId = 4
                        });
                });

            modelBuilder.Entity("National_Park_Blog.Models.National_Parks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NationalParks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Impressive park, a natural beauty",
                            Image = "/images/Black_River_Reservation.jpg",
                            Location = "Ohio",
                            Name = "Black River Reservation"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Gateway to Yellowstone National Park",
                            Image = "/images/Gallatin_Sign.jpg",
                            Location = "Montana",
                            Name = "Gallatin National Park"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The Crown of the Continent",
                            Image = "Glacier_Park_Sign.jpg",
                            Location = "Montana",
                            Name = "Glacier National Park"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Totally Safe",
                            Image = "Rocky_River_Park.jpg",
                            Location = "Ohio",
                            Name = "Rocky River Reservation"
                        });
                });

            modelBuilder.Entity("National_Park_Blog.Models.Blog_Content", b =>
                {
                    b.HasOne("National_Park_Blog.Models.National_Parks", "NationalPark")
                        .WithMany("BlogContent")
                        .HasForeignKey("NationalParkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
