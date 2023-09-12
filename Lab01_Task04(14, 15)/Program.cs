public class Program
{
    private static void Main(string[] args)
    {
        //problem 14
        int a, b, c;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());

        if(a > b)
        {
            if(a > c)
            {
                Console.WriteLine(a);
            } else
            {
                Console.WriteLine(c);
            }
        } else if(b > c)
        {
            Console.WriteLine(b);
        } else
        {
            Console.WriteLine(c);
        }

        //problem 15
        int a1, b1, c1, product;
        a1 = int.Parse(Console.ReadLine());
        b1 = int.Parse(Console.ReadLine());
        c1 = int.Parse(Console.ReadLine());

        int i = 0;
        if(a1 < 0 )
        {
            i++;
        }
        if(b1 < 0 )
        {
            i++;
        }
        if (c1 < 0 )
        {
            i++;
        }
        Console.WriteLine(i == 1 || i == 3 ? "Negative" : "Positive");
    }
}