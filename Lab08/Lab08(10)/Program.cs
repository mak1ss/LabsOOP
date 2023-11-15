using Lab08_10_;
internal class Program
{
    private static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(" ");
        Lab08_10_.Tuple<string, string> tuple = new Lab08_10_.Tuple<string, string>($"{input[0]} {input[1]}", input[2]);
        Console.WriteLine($"{tuple.Item1} -> {tuple.Item2}");

        input = Console.ReadLine().Split(" ");
        Lab08_10_.Tuple<string, int> tuple1 = new Lab08_10_.Tuple<string, int>(input[0], int.Parse(input[1]));
        Console.WriteLine($"{tuple1.Item1} -> {tuple1.Item2}");

        input = Console.ReadLine().Split(" ");
        Lab08_10_.Tuple<int, double> tuple2 = new Lab08_10_.Tuple<int, double>(int.Parse(input[0]), double.Parse(input[1]));
        Console.WriteLine($"{tuple2.Item1} -> {tuple2.Item2}");
    }
}