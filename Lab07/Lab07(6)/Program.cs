
using Lab07_5_;
using Lab07_6_;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IEntity> entities = new List<IEntity>();
        string input;
        while (!(input = Console.ReadLine()).Equals("End"))
        {
            string[] arguments = input.Split(' ');
            switch (arguments[0])
            {
                case "Citizen":
                    entities.Add(new Human(arguments[1], int.Parse(arguments[2]), long.Parse(arguments[3]), arguments[4]));
                    break;

                case "Pet":
                    entities.Add(new Pet(arguments[1], arguments[2]));
                    break;
            }
        }

        string year = Console.ReadLine();
        entities.Where(e => Regex.IsMatch(e.Birthdate, $@"{year}$")).ToList().ForEach(e => Console.WriteLine(e.Birthdate));
    }
}