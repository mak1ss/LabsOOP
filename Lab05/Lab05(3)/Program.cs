using System;
using Lab05;
public class Program
{
    public static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        Chicken chicken = null;
        try
        {
            chicken = new Chicken(age, name);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        if (chicken != null)
        {
            Console.WriteLine(chicken.ToString());
        }
    }
}