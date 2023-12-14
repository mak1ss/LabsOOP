using Lab22.BookShop.Data;
using Lab22.BookShop.Data.Model;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Lab22.BookShop.Startup.Services
{
    public class BookShopService
    {
        private static BookShopService singleton;

        private BookShopContext context;

        private BookShopService(BookShopContext context)
        {
            this.context = context;
        }
        public static BookShopService GetInstance(BookShopContext context)
        {
            if (singleton == null)
            {
                singleton = new BookShopService(context);
                return singleton;
            }
            return singleton;
        }

        public string GetBooksByAgeRestriction(string command)
        {
            if (!Enum.IsDefined(typeof(AgeRestriction), CultureInfo.CurrentCulture.TextInfo.ToTitleCase(command)))
            {
                throw new ArgumentException("Invalid type of restriction");
            }
            AgeRestriction ageRestriction = (AgeRestriction)Enum.Parse(typeof(AgeRestriction), command, true);
            StringBuilder result = new StringBuilder();

            context.Books
                .Where(b => b.AgeRestriction == ageRestriction)
                .OrderBy(b => b.Title).ToList()
                .ForEach(b => result.AppendLine(b.Title));

            return result.ToString();
        }

        public string GetGoldenBooks()
        {
            StringBuilder result = new StringBuilder();
            context.Books
                .Where(b => b.EditionType == EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.Id).ToList()
                .ForEach(b => result.AppendLine(b.Title));

            return result.ToString();
        }

        public string GetBooksByPrice()
        {
            StringBuilder result = new StringBuilder();

            context.Books
                .Where(b => b.Price > 40)
                .OrderByDescending(b => b.Price)
                .ToList()
                .ForEach(b => result.AppendLine($"{b.Title} - ${b.Price}"));

            return result.ToString();
        }

        public string GetBooksNotReleasedIn(int year)
        {
            StringBuilder result = new StringBuilder();
            context.Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.Id).ToList()
                .ForEach(b => result.AppendLine(b.Title));

            return result.ToString();
        }

        public string GetBooksByCategories(string input)
        {
            string[] categories = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower()).Split(" ");
            StringBuilder result = new StringBuilder();
            context.Books
                .Where(b => b.BookCategories
                                .Select(bc => bc.Category.Name)
                                .Intersect(categories).Any()
                      )
                .OrderBy(b => b.Title).ToList()
                .ForEach(b => result.AppendLine(b.Title));

            return result.ToString();
        }

        public string GetBooksReleasedBefore(string input)
        {
            DateOnly inputDate;
            if (!DateOnly.TryParse(input, out inputDate))
            {
                throw new ArgumentException("Invalid date format");
            }
            StringBuilder result = new StringBuilder();
            context.Books
                .Where(b => b.ReleaseDate.Value.CompareTo(inputDate) < 0)
                .OrderByDescending(b => b.ReleaseDate).ToList()
                .ForEach(b => result.AppendLine($"{b.Title} - {b.EditionType} - ${b.Price}"));

            return result.ToString();
        }

        public string GetAuthorNamesEndingIn(string input)
        {
            StringBuilder result = new StringBuilder();
            context.Authors
                .Where(a => a.FirstName.EndsWith(input))
                .OrderBy(a => a.FirstName)
                .ToList()
                .ForEach(a => result.AppendLine($"{a.FirstName} {a.LastName}"));
            return result.ToString();
        }

        public string GetBookTitlesContaining(string input)
        {
            StringBuilder result = new StringBuilder();
            context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .OrderBy(b => b.Title).ToList()
                .ForEach(b => result.AppendLine(b.Title));

            return result.ToString();
        }

        public string GetBooksByAuthor(string input)
        {
            StringBuilder result = new StringBuilder();
            context.Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input))
                .OrderBy(b => b.Id).ToList()
                .ForEach(b => result.AppendLine($"{b.Title} ({b.Author.FirstName} {b.Author.LastName})"));

            return result.ToString();
        }

        public int CountBooks(int input)
        {
            return context.Books
               .Where(b => b.Title.Length > input)
               .Count();
        }

        public string CountCopiesByAuthor()
        {
            StringBuilder result = new StringBuilder();
            context.Books
                .GroupBy(b => b.Author)
                .Select(g =>
                    new
                    {
                        AuthorName = g.Key.FirstName + g.Key.LastName,
                        TotalCopies = g.Sum(b => b.Copies)
                    })
                .OrderByDescending(ab => ab.TotalCopies)
                .ToList()
                .ForEach(ab => result.AppendLine($"{ab.AuthorName} {ab.TotalCopies}"));
            return result.ToString();
        }

        public string GetTotalProfitByCategory()
        {
            StringBuilder result = new StringBuilder();
            context.Categories
                .Join(context.BookCategories,
                c => c.Id,
                bc => bc.CategoryId,
                (c, bc) => new
                {
                    CategoryName = c.Name,
                    bc.BookId
                })
                .Join(context.Books,
                c => c.BookId,
                b => b.Id,
                (c, b) => new
                {
                    c.CategoryName,
                    TotalProfit = b.Copies * b.Price
                })
                .GroupBy(c => c.CategoryName)
                .Select(cb => new
                {
                    CategoryName = cb.Key,
                    TotalProfit = cb.Sum(cb => cb.TotalProfit)
                })
                .OrderByDescending(cb => cb.TotalProfit)
                .ThenBy(cb => cb.CategoryName)
                .ToList()
                .ForEach(cb => result.AppendLine($"{cb.CategoryName} {cb.TotalProfit}"));
            return result.ToString();
        }

        public string GetMostRecentBooks()
        {
            StringBuilder result = new StringBuilder();
            context.Categories
                .Join(context.BookCategories,
                c => c.Id,
                bc => bc.CategoryId,
                (c, bc) => new
                {
                    CategoryName = c.Name,
                    bc.BookId
                })
                .Join(context.Books,
                c => c.BookId,
                b => b.Id,
                (c, b) => new
                {
                    c.CategoryName,
                    b.Title,
                    b.ReleaseDate
                })
                .GroupBy(c => c.CategoryName)
                .Select(cb => new
                {
                    CategoryName = cb.Key,
                    RecentBooks = cb
                                .OrderByDescending(b => b.ReleaseDate)
                                .Take(3)
                })
                .ToList()
                .ForEach(cb =>
                {
                    result.AppendLine($"--{cb.CategoryName}");
                    cb.RecentBooks.ToList()
                    .ForEach(b =>
                    {
                        result.AppendLine($"{b.Title} ({b.ReleaseDate.Value})");
                    });
                });
            return result.ToString();
        }

        public void IncreasePrices()
        {
            context.Books.Where(b => b.ReleaseDate.Value.Year < 2010).ToList().ForEach(b => b.Price += 5);
            context.SaveChanges();
        }

        public int RemoveBooks()
        {
            int result = context.Books.Count();
            context.RemoveRange(context.Books.Where(b => b.Copies < 42));
            context.SaveChanges();
            return result - context.Books.Count();
        }
    }
}
