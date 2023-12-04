using Lab14_10_;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        string input;

        while (!(input = Console.ReadLine()).ToLower().Equals("end"))
        {
            string[] arguments = input.Split(' ');
            people.Add(new Person(arguments[0] + arguments[1], int.Parse(arguments[2])));
        }

        var resultList = people.GroupBy(p => p.Group).OrderBy(g => g.Key).ToList();

        foreach (var group in resultList)
        {
            Console.Write($"{group.Key} ->");
            foreach (var person in group)
            {
                   Console.Write (person.Name);
            }
            Console.WriteLine();
        }
    }
}