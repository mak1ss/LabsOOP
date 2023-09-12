
public class Program
{
    public static void Main()
    {
        //problem 9
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        int area = (((a + b) / 2) * h);
        Console.WriteLine(area);
    }
}