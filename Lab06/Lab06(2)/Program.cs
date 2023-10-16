
using Lab06;
public class Program
{
    public static void main(String[] args)
    {
        try
        {
            string author = Console.ReadLine();
            string title = Console.ReadLine();
            float price = float.Parse(Console.ReadLine());

            Book book = new Book(title, author, price);
            GoldenEditionBook goldBook = new GoldenEditionBook(title, author, price);

            Console.WriteLine(book);
            Console.WriteLine(goldBook);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}