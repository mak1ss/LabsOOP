using System;
using Lab05;
public class Program
{
    public static void Main()
    {
        float length = float.Parse(Console.ReadLine());
        float height = float.Parse(Console.ReadLine());
        float width = float.Parse(Console.ReadLine());
        Box box = null;
        try
        {
            box = new Box(length, width, height);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        if (box != null)
        {
            Console.WriteLine(box.ToString());
        }
    }
}