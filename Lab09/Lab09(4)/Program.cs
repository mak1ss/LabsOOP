using Lab09_4_;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] stoneNumbers = Console.ReadLine().Split(", ").Select(s => int.Parse(s)).ToArray();
        Lake lake = new Lake(stoneNumbers);

        foreach(int stoneNumber in lake)
        {
            Console.Write($"{stoneNumber} ");
        }
    }
}