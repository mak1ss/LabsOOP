using Lab09;
using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        Match match = Regex.Match(input, "Create\\s{\\s*([^}]+)\\s*}");
        if (!match.Success)
        {
            Console.Error.WriteLine("Invalid creation input");
            Environment.Exit(0);
        }
        string elements = match.Groups[1].Value.Trim();
        ListyIterator<string> iterator;
        if (string.IsNullOrEmpty(elements))
        {
            iterator = new ListyIterator<string>(new List<string>());
        }
        else
        {
            iterator = new ListyIterator<string>(elements.Split(" ").ToList());
        }

        while (!(input = Console.ReadLine()).Equals("END"))
        {
            switch (input)
            {
                case "Move":
                    Console.WriteLine(iterator.MoveNext());
                    break;
                case "Print":
                    iterator.Print();
                    break;
                case "HasNext":
                    Console.WriteLine(iterator.HasNext);
                    break;
                case "PrintAll":
                    foreach(string item in iterator)
                    {
                        Console.Write($"{item} ");
                    }
                    break;
                default:
                    Console.WriteLine("Unknown operation");
                    break;
            }
        }
    }
}