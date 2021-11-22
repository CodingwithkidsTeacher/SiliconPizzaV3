﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SiliconPizza.Models;

namespace SiliconPizza.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211022111614_seedDataAdded")]
    partial class seedDataAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SiliconPizza.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Meat Pizza"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Veggie Pizza"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Vegetarian Pizza"
                        });
                });

            modelBuilder.Entity("SiliconPizza.Models.Pizza", b =>
                {
                    b.Property<int>("PizzaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllergyInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPizzaOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PizzaId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Pizzas");

                    b.HasData(
                        new
                        {
                            PizzaId = 1,
                            AllergyInformation = "",
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                            ImageUrl = "~/images/pepperoni.png",
                            InStock = true,
                            IsPizzaOfTheWeek = true,
                            LongDescription = "Large pepperoni pizza with american cheese which comes with a side sauce and a small soft drink",
                            Name = "Pepperoni Piza",
                            Price = 8.95m,
                            ShortDescription = "Our famous pepperoni pizza!"
                        });
                });

            modelBuilder.Entity("SiliconPizza.Models.Pizza", b =>
                {
                    b.HasOne("SiliconPizza.Models.Category", "Category")
                        .WithMany("Pizzas")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SiliconPizza.Models.Category", b =>
                {
                    b.Navigation("Pizzas");
                });
#pragma warning restore 612, 618
        }
    }
}
