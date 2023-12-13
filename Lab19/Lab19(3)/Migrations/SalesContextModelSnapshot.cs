﻿// <auto-generated />
using System;
using Lab19_3_.P03_SalesDatabase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab19_3_.Migrations
{
    [DbContext(typeof(SalesContext))]
    partial class SalesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab19_3_.P03_SalesDatabase.Data.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CustomerId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreditCardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .IsUnicode(false)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Customets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreditCardNumber = "6767-5522-0303-5753",
                            Email = "Emmett_Hayes@hotmail.com",
                            Name = "Emmett Hayes"
                        },
                        new
                        {
                            Id = 2,
                            CreditCardNumber = "4210-6494-9713-1518",
                            Email = "Clinton_Kunze@yahoo.com",
                            Name = "Clinton Kunze"
                        },
                        new
                        {
                            Id = 3,
                            CreditCardNumber = "6771-8933-2473-6760",
                            Email = "Mike.Fay59@yahoo.com",
                            Name = "Mike Fay"
                        },
                        new
                        {
                            Id = 4,
                            CreditCardNumber = "6011-0973-4619-4608",
                            Email = "Calvin93@gmail.com",
                            Name = "Calvin Carter"
                        },
                        new
                        {
                            Id = 5,
                            CreditCardNumber = "6767-3052-1548-1899",
                            Email = "Gloria.OKon@yahoo.com",
                            Name = "Gloria O'Kon"
                        },
                        new
                        {
                            Id = 6,
                            CreditCardNumber = "6381-6364-3299-3746",
                            Email = "Duane70@gmail.com",
                            Name = "Duane Schultz"
                        },
                        new
                        {
                            Id = 7,
                            CreditCardNumber = "4519484841312",
                            Email = "Carl_Wiza@gmail.com",
                            Name = "Carl Wiza"
                        },
                        new
                        {
                            Id = 8,
                            CreditCardNumber = "6767-1674-0188-9289",
                            Email = "Kellie.Lindgren@yahoo.com",
                            Name = "Kellie Lindgren"
                        },
                        new
                        {
                            Id = 9,
                            CreditCardNumber = "6372-8278-5979-5737",
                            Email = "Dallas_Nicolas@gmail.com",
                            Name = "Dallas Nicolas"
                        },
                        new
                        {
                            Id = 10,
                            CreditCardNumber = "3528-0212-2851-8984",
                            Email = "Johnny36@hotmail.com",
                            Name = "Johnny Sporer"
                        });
                });

            modelBuilder.Entity("Lab19_3_.P03_SalesDatabase.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProductId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Name = "Licensed Rubber Computer",
                            Price = 246.38681f,
                            Quantity = 55
                        },
                        new
                        {
                            Id = 2,
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Name = "Handmade Wooden Ball",
                            Price = 743.9417f,
                            Quantity = 47
                        },
                        new
                        {
                            Id = 3,
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Name = "Ergonomic Wooden Mouse",
                            Price = 189.6792f,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 4,
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Name = "Sleek Metal Shoes",
                            Price = 616.309f,
                            Quantity = 51
                        },
                        new
                        {
                            Id = 5,
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Name = "Ergonomic Soft Bacon",
                            Price = 95.58535f,
                            Quantity = 87
                        },
                        new
                        {
                            Id = 6,
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Name = "Handcrafted Granite Bacon",
                            Price = 74.35718f,
                            Quantity = 87
                        },
                        new
                        {
                            Id = 7,
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Tasty Concrete Shirt",
                            Price = 198.99988f,
                            Quantity = 36
                        },
                        new
                        {
                            Id = 8,
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Name = "Refined Plastic Ball",
                            Price = 786.77374f,
                            Quantity = 66
                        },
                        new
                        {
                            Id = 9,
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Name = "Fantastic Concrete Table",
                            Price = 472.4277f,
                            Quantity = 31
                        },
                        new
                        {
                            Id = 10,
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Name = "Licensed Rubber Shoes",
                            Price = 717.15326f,
                            Quantity = 43
                        });
                });

            modelBuilder.Entity("Lab19_3_.P03_SalesDatabase.Data.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SaleId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("StoreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("StoreId");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            Id = 6,
                            CustomerId = 4,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 3,
                            StoreId = 3
                        },
                        new
                        {
                            Id = 7,
                            CustomerId = 7,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 5,
                            StoreId = 5
                        },
                        new
                        {
                            Id = 8,
                            CustomerId = 6,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 6,
                            StoreId = 1
                        },
                        new
                        {
                            Id = 9,
                            CustomerId = 10,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 2,
                            StoreId = 5
                        },
                        new
                        {
                            Id = 10,
                            CustomerId = 2,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 10,
                            StoreId = 3
                        },
                        new
                        {
                            Id = 11,
                            CustomerId = 3,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 3,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 12,
                            CustomerId = 5,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 4,
                            StoreId = 1
                        },
                        new
                        {
                            Id = 13,
                            CustomerId = 6,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 9,
                            StoreId = 1
                        },
                        new
                        {
                            Id = 14,
                            CustomerId = 7,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 8,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 15,
                            CustomerId = 6,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 8,
                            StoreId = 4
                        },
                        new
                        {
                            Id = 16,
                            CustomerId = 6,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 7,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 17,
                            CustomerId = 5,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 9,
                            StoreId = 5
                        },
                        new
                        {
                            Id = 18,
                            CustomerId = 7,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 1,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 19,
                            CustomerId = 5,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 6,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 20,
                            CustomerId = 3,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 7,
                            StoreId = 1
                        },
                        new
                        {
                            Id = 21,
                            CustomerId = 6,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 6,
                            StoreId = 4
                        },
                        new
                        {
                            Id = 22,
                            CustomerId = 10,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 1,
                            StoreId = 1
                        },
                        new
                        {
                            Id = 23,
                            CustomerId = 10,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 3,
                            StoreId = 2
                        },
                        new
                        {
                            Id = 24,
                            CustomerId = 4,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 7,
                            StoreId = 5
                        },
                        new
                        {
                            Id = 25,
                            CustomerId = 3,
                            Date = new DateOnly(1, 1, 1),
                            ProductId = 2,
                            StoreId = 1
                        });
                });

            modelBuilder.Entity("Lab19_3_.P03_SalesDatabase.Data.Models.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("StoreId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Stores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Friesen, Bechtelar and Glover"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rolfson - Turner"
                        },
                        new
                        {
                            Id = 3,
                            Name = "White, Gutmann and Ortiz"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Braun Group"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Corkery, Conroy and Hackett"
                        });
                });

            modelBuilder.Entity("Lab19_3_.P03_SalesDatabase.Data.Models.Sale", b =>
                {
                    b.HasOne("Lab19_3_.P03_SalesDatabase.Data.Models.Customer", "Customer")
                        .WithMany("Sales")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab19_3_.P03_SalesDatabase.Data.Models.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab19_3_.P03_SalesDatabase.Data.Models.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("Lab19_3_.P03_SalesDatabase.Data.Models.Customer", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Lab19_3_.P03_SalesDatabase.Data.Models.Product", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
