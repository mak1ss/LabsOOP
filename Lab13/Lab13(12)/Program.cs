internal class Program
{
    private static void Main(string[] args)
    {
        SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();
        
        string input;
        while (!(input = Console.ReadLine()).Equals("End"))
        {
            string[] parameters = input.Split(" ");
            if (parameters[0].Equals("A"))
            {
                phoneBook.Add(parameters[1], parameters[2]);
            }
            else if (parameters[0].Equals("S"))
            {
                if (!phoneBook.ContainsKey(parameters[1]))
                {
                    Console.WriteLine($"Contact {parameters[1]} doesn't exist");
                    continue;
                }
                Console.WriteLine($"{parameters[1]} -> {phoneBook[parameters[1]]}");
            } else if (parameters[0].Equals("ListAll"))
            {
                //phoneBook = phoneBook.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                phoneBook.ToList().ForEach(x => Console.WriteLine($"{x.Key} -> {x.Value}"));
            }
        }
    }
}