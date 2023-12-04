using Lab14;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        string input;

        while (!(input = Console.ReadLine()).ToLower().Equals("end"))
        {
            string[] arguments = input.Split(' ');
            students.Add(new Student(arguments[0], arguments[1], int.Parse(arguments[2])));
        }

        var values = students
            .Where(s => s.Age >= 18 && s.Age <= 24)
            .Select(s => new { s.FirstName, s.LastName, s.Age });
        foreach (var item in values)
        {
            Console.WriteLine($"{item.FirstName} {item.LastName} {item.Age}");
        }
    }
}