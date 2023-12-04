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
            string[] marks = input.Substring(arguments[0].Length + 1).Split(" ");

            students.Add(new Student(arguments[0], marks));
        }

        var studentsMarks = students
        .Where(s => s.Faculty.EndsWith("14") || s.Faculty.EndsWith("15"))
        .Select(s => s.Marks)
        .ToList();

        foreach (var marks in studentsMarks)
        {
            marks.ToList().ForEach(Console.Write);

            Console.WriteLine();
        }
    }
}