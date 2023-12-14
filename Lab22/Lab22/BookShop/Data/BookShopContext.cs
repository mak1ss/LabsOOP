using Lab22.BookShop.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22.BookShop.Data
{
    public class BookShopContext : DbContext
    {
        public DbSet<Author> Authors => Set<Author>();
        public DbSet<Book> Books => Set<Book>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<BookCategory> BookCategories => Set<BookCategory>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=bookShopDatabase;Trusted_Connection=True;Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Author>().HasData(
                new List<Author>()
                {
                    new Author { Id = 1, FirstName = "John", LastName = "Svarovski"} ,
                    new Author { Id = 2, FirstName =  null, LastName = "Markoni"}
                }
                );
            modelBuilder.Entity<Category>().HasData(
                new List<Category>()
                {
                    new Category { Id = 1, Name = "Horror"},
                    new Category { Id = 2, Name = "Detective"},
                    new Category { Id = 3, Name = "Drama"},
                    new Category { Id = 4, Name = "Thriller"}
                }
                );
            modelBuilder.Entity<Book>().HasData(
                new List<Book>()
                {
                    new Book { Id = 1, AuthorId = 1, Title ="Horror of London",
                        Price = 159.99f, Description = "A great Book", Copies = 100, EditionType = EditionType.Gold,
                        ReleaseDate = DateOnly.Parse("2023-12-12"), AgeRestriction = AgeRestriction.Adult},
                    new Book { Id = 2, AuthorId = 1, Title ="Drama of London",
                        Price = 159.99f, Description = "Another great Book", Copies = 10, EditionType = EditionType.Promo,
                        ReleaseDate = DateOnly.Parse("2024-02-12"), AgeRestriction = AgeRestriction.Teen},
                    new Book { Id = 3, AuthorId = 2, Title ="Detective of Chernivtsi",
                        Price = 159.99f, Description = "An Ok Book", Copies = 10, EditionType = EditionType.Promo,
                        ReleaseDate = DateOnly.Parse("2020-02-12"), AgeRestriction = AgeRestriction.Minor},
                    new Book { Id = 4, AuthorId = 1, Title = "Thriller in Paris",
                        Price = 129.99f, Description = "A suspenseful thriller", Copies = 50, EditionType = EditionType.Normal, 
                        ReleaseDate = DateOnly.Parse("2022-10-15"), AgeRestriction = AgeRestriction.Adult},
                    new Book { Id = 5, AuthorId = 1, Title = "Mystery Mansion",
                        Price = 179.99f, Description = "Unravel the secrets of the haunted mansion", Copies = 30, EditionType = EditionType.Gold,
                        ReleaseDate = DateOnly.Parse("2023-05-20"), AgeRestriction = AgeRestriction.Teen},
                    new Book { Id = 6, AuthorId = 2, Title = "Adventure in the Jungle",
                        Price = 99.99f, Description = "Embark on a thrilling jungle adventure", Copies = 20, EditionType = EditionType.Promo,
                        ReleaseDate = DateOnly.Parse("2023-08-05"), AgeRestriction = AgeRestriction.Minor},
                    new Book { Id = 7, AuthorId = 2, Title = "Historical Chronicles", 
                        Price = 139.99f, Description = "Explore the rich history of ancient civilizations", Copies = 40, EditionType = EditionType.Normal,
                        ReleaseDate = DateOnly.Parse("2022-12-01"), AgeRestriction = AgeRestriction.Adult},
                    new Book { Id = 8, AuthorId = 1, Title = "Comedy Club Chronicles", 
                        Price = 119.99f, Description = "Laugh out loud with hilarious comedy tales", Copies = 25, EditionType = EditionType.Gold,
                        ReleaseDate = DateOnly.Parse("2024-03-10"), AgeRestriction = AgeRestriction.Teen},
                    new Book { Id = 9, AuthorId = 2, Title = "Romantic Getaway",
                        Price = 149.99f, Description = "Experience the magic of love in exotic locations", Copies = 15, EditionType = EditionType.Gold,
                        ReleaseDate = DateOnly.Parse("2021-07-22"), AgeRestriction = AgeRestriction.Adult},
                    new Book { Id = 10, AuthorId = 1, Title = "Sci-Fi Odyssey",
                        Price = 169.99f, Description = "Embark on an intergalactic journey", Copies = 35, EditionType = EditionType.Normal,
                        ReleaseDate = DateOnly.Parse("2022-05-18"), AgeRestriction = AgeRestriction.Teen},
                    new Book { Id = 11, AuthorId = 1, Title = "Old book",
                        Price = 0, Description = "ooooold boook", Copies = 1, EditionType = EditionType.Normal,
                        ReleaseDate = DateOnly.Parse("2009-05-18"), AgeRestriction = AgeRestriction.Teen}
                }
                );
            modelBuilder.Entity<BookCategory>().HasData(
                    new List<BookCategory>()
                    {
                        new BookCategory { BookId = 1, CategoryId = 1},
                        new BookCategory { BookId = 1, CategoryId = 4},
                        new BookCategory { BookId = 2, CategoryId = 3},
                        new BookCategory { BookId = 3, CategoryId = 2},
                        new BookCategory { BookId = 3, CategoryId = 4},
                        new BookCategory { BookId = 3, CategoryId = 3},
                        new BookCategory { BookId = 4, CategoryId = 2},
                        new BookCategory { BookId = 4, CategoryId = 4},
                        new BookCategory { BookId = 5, CategoryId = 1},
                        new BookCategory { BookId = 6, CategoryId = 3},
                        new BookCategory { BookId = 7, CategoryId = 1},
                        new BookCategory { BookId = 8, CategoryId = 4},
                        new BookCategory { BookId = 9, CategoryId = 3},
                        new BookCategory { BookId = 10, CategoryId = 2},
                    }
                );
        }
    }
}
