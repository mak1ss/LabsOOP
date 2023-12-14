﻿// <auto-generated />
using System;
using Lab22.BookShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab22.Migrations
{
    [DbContext(typeof(BookShopContext))]
    [Migration("20231214232621_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab22.BookShop.Data.Model.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AuthorID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "John",
                            LastName = "Svarovski"
                        },
                        new
                        {
                            Id = 2,
                            LastName = "Markoni"
                        });
                });

            modelBuilder.Entity("Lab22.BookShop.Data.Model.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BookId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AgeRestriction")
                        .HasColumnType("int");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("Copies")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("EditionType")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<DateOnly?>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AgeRestriction = 2,
                            AuthorId = 1,
                            Copies = 100,
                            Description = "A great Book",
                            EditionType = 2,
                            Price = 159.99f,
                            ReleaseDate = new DateOnly(2023, 12, 12),
                            Title = "Horror of London"
                        },
                        new
                        {
                            Id = 2,
                            AgeRestriction = 1,
                            AuthorId = 1,
                            Copies = 10,
                            Description = "Another great Book",
                            EditionType = 1,
                            Price = 159.99f,
                            ReleaseDate = new DateOnly(2024, 2, 12),
                            Title = "Drama of London"
                        },
                        new
                        {
                            Id = 3,
                            AgeRestriction = 0,
                            AuthorId = 2,
                            Copies = 10,
                            Description = "An Ok Book",
                            EditionType = 1,
                            Price = 159.99f,
                            ReleaseDate = new DateOnly(2020, 2, 12),
                            Title = "Detective of Chernivtsi"
                        },
                        new
                        {
                            Id = 4,
                            AgeRestriction = 2,
                            AuthorId = 1,
                            Copies = 50,
                            Description = "A suspenseful thriller",
                            EditionType = 0,
                            Price = 129.99f,
                            ReleaseDate = new DateOnly(2022, 10, 15),
                            Title = "Thriller in Paris"
                        },
                        new
                        {
                            Id = 5,
                            AgeRestriction = 1,
                            AuthorId = 1,
                            Copies = 30,
                            Description = "Unravel the secrets of the haunted mansion",
                            EditionType = 2,
                            Price = 179.99f,
                            ReleaseDate = new DateOnly(2023, 5, 20),
                            Title = "Mystery Mansion"
                        },
                        new
                        {
                            Id = 6,
                            AgeRestriction = 0,
                            AuthorId = 2,
                            Copies = 20,
                            Description = "Embark on a thrilling jungle adventure",
                            EditionType = 1,
                            Price = 99.99f,
                            ReleaseDate = new DateOnly(2023, 8, 5),
                            Title = "Adventure in the Jungle"
                        },
                        new
                        {
                            Id = 7,
                            AgeRestriction = 2,
                            AuthorId = 2,
                            Copies = 40,
                            Description = "Explore the rich history of ancient civilizations",
                            EditionType = 0,
                            Price = 139.99f,
                            ReleaseDate = new DateOnly(2022, 12, 1),
                            Title = "Historical Chronicles"
                        },
                        new
                        {
                            Id = 8,
                            AgeRestriction = 1,
                            AuthorId = 1,
                            Copies = 25,
                            Description = "Laugh out loud with hilarious comedy tales",
                            EditionType = 2,
                            Price = 119.99f,
                            ReleaseDate = new DateOnly(2024, 3, 10),
                            Title = "Comedy Club Chronicles"
                        },
                        new
                        {
                            Id = 9,
                            AgeRestriction = 2,
                            AuthorId = 2,
                            Copies = 15,
                            Description = "Experience the magic of love in exotic locations",
                            EditionType = 2,
                            Price = 149.99f,
                            ReleaseDate = new DateOnly(2021, 7, 22),
                            Title = "Romantic Getaway"
                        },
                        new
                        {
                            Id = 10,
                            AgeRestriction = 1,
                            AuthorId = 1,
                            Copies = 35,
                            Description = "Embark on an intergalactic journey",
                            EditionType = 0,
                            Price = 169.99f,
                            ReleaseDate = new DateOnly(2022, 5, 18),
                            Title = "Sci-Fi Odyssey"
                        },
                        new
                        {
                            Id = 11,
                            AgeRestriction = 1,
                            AuthorId = 1,
                            Copies = 1,
                            Description = "ooooold boook",
                            EditionType = 0,
                            Price = 0f,
                            ReleaseDate = new DateOnly(2009, 5, 18),
                            Title = "Old book"
                        });
                });

            modelBuilder.Entity("Lab22.BookShop.Data.Model.BookCategory", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("BookId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BookCategories");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            BookId = 1,
                            CategoryId = 4
                        },
                        new
                        {
                            BookId = 2,
                            CategoryId = 3
                        },
                        new
                        {
                            BookId = 3,
                            CategoryId = 2
                        },
                        new
                        {
                            BookId = 3,
                            CategoryId = 4
                        },
                        new
                        {
                            BookId = 3,
                            CategoryId = 3
                        },
                        new
                        {
                            BookId = 4,
                            CategoryId = 2
                        },
                        new
                        {
                            BookId = 4,
                            CategoryId = 4
                        },
                        new
                        {
                            BookId = 5,
                            CategoryId = 1
                        },
                        new
                        {
                            BookId = 6,
                            CategoryId = 3
                        },
                        new
                        {
                            BookId = 7,
                            CategoryId = 1
                        },
                        new
                        {
                            BookId = 8,
                            CategoryId = 4
                        },
                        new
                        {
                            BookId = 9,
                            CategoryId = 3
                        },
                        new
                        {
                            BookId = 10,
                            CategoryId = 2
                        });
                });

            modelBuilder.Entity("Lab22.BookShop.Data.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CategoryId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Detective"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Thriller"
                        });
                });

            modelBuilder.Entity("Lab22.BookShop.Data.Model.Book", b =>
                {
                    b.HasOne("Lab22.BookShop.Data.Model.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Lab22.BookShop.Data.Model.BookCategory", b =>
                {
                    b.HasOne("Lab22.BookShop.Data.Model.Book", "Book")
                        .WithMany("BookCategories")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab22.BookShop.Data.Model.Category", "Category")
                        .WithMany("CategoriesBook")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Lab22.BookShop.Data.Model.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Lab22.BookShop.Data.Model.Book", b =>
                {
                    b.Navigation("BookCategories");
                });

            modelBuilder.Entity("Lab22.BookShop.Data.Model.Category", b =>
                {
                    b.Navigation("CategoriesBook");
                });
#pragma warning restore 612, 618
        }
    }
}