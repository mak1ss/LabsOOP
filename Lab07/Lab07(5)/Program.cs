
using Lab07_5_;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Entity> entities = new List<Entity>();
        string input;
        while(!(input = Console.ReadLine()).Equals("End"))
        {
            string[] arguments = input.Split(' ');
            if(arguments.Length == 2 )
            {
                entities.Add(new Robot(arguments[0], long.Parse(arguments[1])));
            } else
            {
                entities.Add(new Human(arguments[0], int.Parse(arguments[1]), long.Parse(arguments[2])));
            }
        }

        string lastDigits = Console.ReadLine();
        entities.Where(e => Regex.IsMatch(e.Id.ToString(), $@"{lastDigits}$")).ToList().ForEach(e => Console.WriteLine(e.Id));
    }
}