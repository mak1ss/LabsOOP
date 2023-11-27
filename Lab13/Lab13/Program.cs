internal class Program
{
    private static void Main(string[] args)
    {
        char[] input = Console.ReadLine().ToCharArray();
        foreach (var item in input.Reverse())
        {
            Console.Write(item);
        }
    }
}