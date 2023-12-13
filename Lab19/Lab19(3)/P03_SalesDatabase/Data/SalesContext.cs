using Lab19_3_.P03_SalesDatabase.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;

namespace Lab19_3_.P03_SalesDatabase.Data
{
    public class SalesContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Customer> Customets => Set<Customer>();
        public DbSet<Store> Stores => Set<Store>();
        public DbSet<Sale> Sales => Set<Sale>();

        public SalesContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(true);
            optionsBuilder.UseSqlServer("Server=localhost;Database=salesDatabase;Trusted_Connection=True;Encrypt=false");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            int id = 1;
            var productFaker = new Faker<Product>()
                .RuleFor(p => p.Name, f => f.Commerce.ProductName())
                .RuleFor(p => p.Quantity, f => f.Random.Int(1, 100))
                .RuleFor(p => p.Price, f => f.Random.Float(1, 1000))
                .RuleFor(p => p.Description, f => f.Commerce.ProductDescription());

            var products = productFaker.Generate(10);
            products.ForEach(p => p.Id = id++);
            modelBuilder.Entity<Product>().HasData(products);
            Console.WriteLine("Products created");
            products.ForEach(Console.WriteLine);

            var customerFaker = new Faker<Customer>()
                .RuleFor(c => c.Name, f => f.Person.FullName)
                .RuleFor(c => c.Email, f => f.Person.Email)
                .RuleFor(c => c.CreditCardNumber, f => f.Finance.CreditCardNumber());

            var customers = customerFaker.Generate(10);
            id = 1;
            customers.ForEach(c => c.Id = id++);
            modelBuilder.Entity<Customer>().HasData(customers);

            var storeFaker = new Faker<Store>()
                .RuleFor(s => s.Name, f => f.Company.CompanyName());
            var stores = storeFaker.Generate(5);
            id = 1;
            stores.ForEach(s => s.Id = id++);
            modelBuilder.Entity<Store>().HasData(stores);

            var saleFaker = new Faker<Sale>()
                .RuleFor(s => s.ProductId, f => f.PickRandom(products).Id)
                .RuleFor(s => s.CustomerId, f => f.PickRandom(customers).Id)
                .RuleFor(s => s.StoreId, f => f.PickRandom(stores).Id);
                

            var sales = saleFaker.Generate(20);
            sales.ForEach(s => s.Id = id++);
            modelBuilder.Entity<Sale>().HasData(sales);
        }
    }
}

