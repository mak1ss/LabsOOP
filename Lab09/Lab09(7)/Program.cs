using Lab09_6_;

internal class Program
{
    private static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        SortedSet<Person> sortedSet = new SortedSet<Person>();
        HashSet<Person> hashSet = new HashSet<Person>();
        Person p;
        string[] input;
        for (int i = 0; i < N; i++)
        {
            input = Console.ReadLine().Split(" ");
            p = new Person(input[0], int.Parse(input[1]));
            sortedSet.Add(p);
            hashSet.Add(p);
        }
        Console.WriteLine(sortedSet.Count);
        Console.WriteLine(hashSet.Count);
    }
}