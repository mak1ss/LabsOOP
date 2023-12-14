using Lab22.BookShop.Data;
using Lab22.BookShop.Startup.Services;

internal class Startup
{
    private static void Main(string[] args)
    {
        BookShopService service = BookShopService.GetInstance(new BookShopContext());
        Console.WriteLine(service.GetBooksByAgeRestriction("minor"));
        Console.WriteLine(service.GetBooksNotReleasedIn(2023));
        Console.WriteLine(service.GetBooksByPrice());
        Console.WriteLine(service.GetBooksByCategories("horrOr detective"));
        Console.WriteLine(service.GetBooksReleasedBefore("2023-10-01"));

        Console.WriteLine(service.GetTotalProfitByCategory());
        Console.WriteLine(service.GetMostRecentBooks());
        service.IncreasePrices();
        Console.WriteLine(service.GetBooksReleasedBefore("2010-12-12"));

        Console.WriteLine(service.RemoveBooks());
    }
}