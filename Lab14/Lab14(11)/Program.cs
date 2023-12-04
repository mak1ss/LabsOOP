using Lab14;
using Lab14_11_;

internal class Program
{
    private static void Main(string[] args)
    {
        List<StudentSpecialty> specialities = new List<StudentSpecialty>();

        string input;

        while (!(input = Console.ReadLine()).Equals("Students:"))
        {
            string[] arguments = input.Split(" ");
            specialities.Add(new StudentSpecialty(arguments[0] + arguments[1], int.Parse(arguments[2])));
        }

        List<Student> students = new List<Student>();

        while (!(input = Console.ReadLine()).ToLower().Equals("end"))
        {
            string[] arguments = input.Split(' ');
            students.Add(new Student(arguments[1] + arguments[2], int.Parse(arguments[0])));
        }

        students
            .Join(specialities,
                stud => stud.Faculty,
                spec => spec.Faculty,
                (stud, spec) => new { stud.Name, stud.Faculty, spec.SpecialtyName })
            .OrderBy(stud => stud.Name)
            .ToList()
            .ForEach(stud => Console.WriteLine($"{stud.Name} {stud.Faculty} {stud.SpecialtyName}"));
    }
}