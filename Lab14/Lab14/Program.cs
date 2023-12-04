﻿
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

        students.Where(s => s.GroupId == 2).OrderBy(s => s.FirstName).ToList().ForEach(s => Console.WriteLine(s.FirstName + " " + s.LastName));
    }
}