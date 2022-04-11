﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using template_csharp_reviews_site;

namespace template_csharp_reviews_site.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220224182014_updatedWendysPng")]
    partial class updatedWendysPng
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("template_csharp_reviews_site.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Information")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Cleveland",
                            Image = "https://th.bing.com/th/id/R.a7030fb5624db3715b9a0b0698b1352f?rik=qMWOVvISFUC9Ig&riu=http%3a%2f%2fpngimg.com%2fuploads%2fmcdonalds%2fmcdonalds_PNG19.png&ehk=DcGet8JyK0nOmVYPW80XxvGb5RhYzJs4JLr%2fCOBW8Wk%3d&risl=&pid=ImgRaw&r=0",
                            Information = "McDonald's is the most popular and common fast food chain in The USA and Canada. McDonald's is the world's largest restaurant chain by revenue, serving over 69 million customers daily in over 100 countries across 37,855 outlets as of 2018",
                            Name = "McDonalds"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Cleveland",
                            Image = "https://freepikpsd.com/file/2019/11/wendys-logo-transparent-png-2-Images.png",
                            Information = "Wendy's is an American international fast food restaurant chain founded by Dave Thomas on November 15, 1969, in Columbus, Ohio.",
                            Name = "Wendys"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Cleveland",
                            Image = "https://logos-world.net/wp-content/uploads/2021/08/Chick-fil-A-Emblem.png",
                            Information = "Chick-fil-A a play on the American English pronunciation of filet. Is one of the largest American fast food restaurant chains and the largest whose specialty is chicken sandwiches. Its headquarters is in College Park, Georgia.",
                            Name = "Chick-Fil-A"
                        });
                });

            modelBuilder.Entity("template_csharp_reviews_site.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Absolutely the worst restaurant!Always short staffed...",
                            Name = "Sue",
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "Overrated!",
                            Name = "Leah",
                            RestaurantId = 2
                        },
                        new
                        {
                            Id = 3,
                            Content = "Very Meeeeeeh!",
                            Name = "Poppy",
                            RestaurantId = 3
                        });
                });

            modelBuilder.Entity("template_csharp_reviews_site.Models.Review", b =>
                {
                    b.HasOne("template_csharp_reviews_site.Models.Restaurant", "Restaurant")
                        .WithMany("Reviews")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("template_csharp_reviews_site.Models.Restaurant", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
