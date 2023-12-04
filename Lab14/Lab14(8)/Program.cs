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
            string[] marks = input.Substring(input.IndexOf(arguments[2])).Split(" ");

            students.Add(new Student(arguments[0], arguments[1], marks));
        }

        students
            .Where(s => s.Marks.Count(m => int.Parse(m) <= 3) >= 2)
            .ToList()
            .ForEach(s => Console.WriteLine($"{s.FirstName} {s.LastName}"));
    }
}