using Lab07_3_;

internal class Program
{
    private static void Main(string[] args)
    {
        string driver = Console.ReadLine();
        Ferrari ferrari = new Ferrari("488-Spider", driver);

        Console.WriteLine($"{ferrari.Model}/{ferrari.Break()}/{ferrari.Gas()}/{ferrari.Driver}");
    }
}