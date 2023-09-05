
public class Program
{
    private static void Main(string[] args)
    {
        //problem 12
        int input = int.Parse(Console.ReadLine());
        if(input > 20 && input % 1 == 0)
        {
            Console.WriteLine(true);
        } else
        {
            Console.WriteLine(false);
        }
        
        //problem 13
        int input1 = int.Parse(Console.ReadLine());
        if(input % 9 == 0 || input % 11 == 0 || input % 13 == 0) 
        { 
            Console.WriteLine(true);
        } else
        {
            Console.WriteLine(false); 
        }

    }
}