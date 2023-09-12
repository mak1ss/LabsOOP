public class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int factorial = 1;
        for(int i = 2; i <= n; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine(factorial);
    }
}