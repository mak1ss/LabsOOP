
public class Program
{
    public static void Main()
    {
        //problem 10
        int n = int.Parse(Console.ReadLine());

        int lastDigit = n % 10;
        Console.WriteLine(lastDigit);

        //problem 11
        int number = int.Parse(Console.ReadLine());
        int digit = int.Parse(Console.ReadLine());

        int result = (number / (int)Math.Pow(10, digit - 1) % 10);
        Console.WriteLine(result);
    }
}