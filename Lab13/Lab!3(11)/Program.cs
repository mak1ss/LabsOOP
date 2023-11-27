internal class Program
{
    private static void Main(string[] args)
    {
        string A = Console.ReadLine();
        string B = Console.ReadLine();

        string output =  A.Any(a => B.Contains(a)) ? "yes" : "no";
        Console.WriteLine(output);
    }
}