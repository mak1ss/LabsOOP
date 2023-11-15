using Lab08_7_;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomList<string> list = new CustomList<string>();
        string input;
        while (!(input = Console.ReadLine()).Equals("End"))
        {
            string[] commands = input.Split(' ');
            switch (commands[0])
            {
                case "Add":
                    list.Add(commands[1]);
                    break;
                case "Remove":
                    Console.WriteLine(list.Remove(int.Parse(commands[1])));
                    break;
                case "Contains":
                    Console.WriteLine(list.Contains(commands[1]));
                    break;
                case "Swap":
                    list.Swap(int.Parse(commands[1]), int.Parse(commands[2]));
                    break;
                case "Greater":
                    Console.WriteLine(list.CountGreaterThan(commands[1]));
                    break;
                case "Max":
                    Console.WriteLine(list.Max());
                    break;
                case "Min":
                    Console.WriteLine(list.Min());
                    break;
                case "Print":
                    Console.WriteLine(list.ToString());
                    break;
                default:
                    Console.WriteLine("Unknown Command");
                    break;
            }
        }
    }
}