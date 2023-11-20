using Lab09_5_;

internal class Program
{
    private static void Main(string[] args)
    {   
        string input;
        List<Person> persons = new List<Person>();
        while(!(input = Console.ReadLine()).Equals("END"))
        {
            string[] arguments = input.Split(' ');
            Person person = new Person(arguments[0], int.Parse(arguments[1]), arguments[2]);
            persons.Add(person);
        }
        int index = int.Parse(Console.ReadLine()) - 1;
        Person toCompare = persons[index];
        int equalPersons = 0;
        int notEqual = persons.Count - 1;
        for(int i = 0; i < persons.Count; i++)
        {
            if(i == index)
            {
                continue;
            }
            if (toCompare.CompareTo(persons[i]) == 0)
            {
                equalPersons++;
                notEqual--;
            }
        }
        if(equalPersons == 0)
        {
            Console.WriteLine("No Matches");
        }
        else
        {
            Console.WriteLine($"{equalPersons} {notEqual} {persons.Count}");
        }
    }
}