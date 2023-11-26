using Lab11_4_;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomList jobs = new CustomList();
        Dictionary<string, IEmployee> employees = new Dictionary<string, IEmployee>();

        string input;
        while (!(input = Console.ReadLine()).Equals("End"))
        {
            string[] commands = input.Split(' ');
            switch (commands[0])
            {
                case "Job":
                    if (!employees.ContainsKey(commands[3]))
                    {
                        Console.WriteLine("Unknown employee");
                        continue;
                    }
                    jobs.AddJob(new Job(employees[commands[3]], int.Parse(commands[2]), commands[1]));
                    break;

                case "StandartEmployee":
                    employees.Add(commands[1], new StandartTimeEmployee(commands[1]));
                    break;

                case "PartTimeEmployee":
                    employees.Add(commands[1], new PartTimeEmployee(commands[1]));
                    break;

                case "Pass":
                    jobs.PassWeek();
                    break;

                case "Status":
                    Console.WriteLine(jobs.Status());
                    break;

                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
        }

    }
}