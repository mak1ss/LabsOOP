using Lab09_6_;

internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        SortedSet<Person> nameSorted = new SortedSet<Person>(new PersonNameComparator());
        SortedSet<Person> ageSorted = new SortedSet<Person>(new PersonAgeComparator());
        Person p;
        string[] input;
        for (int i = 0; i < N; i++)
        {
            input = Console.ReadLine().Split(" ");
            p = new Person(input[0], int.Parse(input[1]));
            nameSorted.Add(p);
            ageSorted.Add(p);
        }
        foreach(Person item in nameSorted)
        {
            Console.WriteLine(item);
        }
        foreach(Person item in ageSorted)
        {
            Console.WriteLine(item);
        }
    }
}