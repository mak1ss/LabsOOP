using Lab_02_;
using Lab07;

internal class Program
{
    private static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string id = Console.ReadLine();
        string birthdate = Console.ReadLine();

        IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
        IBirthable ibirthable = new Citizen(name, age, id, birthdate);

        Console.WriteLine(identifiable.Id);
        Console.WriteLine(ibirthable.BirthDate);
    }
}