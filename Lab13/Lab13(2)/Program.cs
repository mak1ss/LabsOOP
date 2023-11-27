internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        input = input.Length < 20 ? input.PadRight(20, '*') : input.Substring(0, 20);
        
        Console.Write(input);
    }
}