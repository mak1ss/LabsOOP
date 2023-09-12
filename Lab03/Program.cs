using Lab03;
using System.Globalization;
public class Program 
{
        //problem 1
        private void FirstProblem()
        {
            
            Person first = new Person("Pesho", 20);
            Person second = new Person("Gosho", 18);
            Person third = new Person("Stamat", 43);
        }
        
        //problem 3
        private void ThirdProblem()
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                int age = int.Parse(input[1]);

                family.AddMember(new Person(input[0], age));

                Console.WriteLine(family.GetOldestMember().ToString());
            }
        }

        //problem 4
        private static void FourthProblem()
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                int age = int.Parse(input[1]);

                family.AddMember(new Person(input[0], age));
            }

            List<Person> result = family.GetFamily();
            result.Sort((p1, p2) => p1.GetName().CompareTo(p2.GetName()));
            foreach (Person person in result)
            {
                if (person.GetAge() > 30)
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }

    //problem 5
    private static void FifthProblem() 
    { 
        DateModifier dateModifier = new DateModifier();
        string first = Console.ReadLine();
        string second = Console.ReadLine(); 
        Console.WriteLine(dateModifier.CalcDifference(first, second));
    }

    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        int n = int.Parse(Console.ReadLine());
        Employee e = null;
        for(int i = 0; i < n;i++)
        {
            string[] values = Console.ReadLine().Split(" ");
            e = new Employee(values[0], double.Parse(values[1]), values[2], values[3]);
            if(values.Length > 4)
            {
                if (values[4].Contains('@')) 
                {
                    e.SetEmail(values[4]);
                } else
                {
                    e.SetAge(int.Parse(values[4]));
                }

                if(values.Length > 5)
                {
                    e.SetAge(int.Parse(values[5]));
                }
                
            }
            employees.Add(e);
        }

        string bestDepartment = CalcDepartment(employees);
        Console.WriteLine("Hightest average salary : " + bestDepartment);
        employees.Sort((e1, e2) => (int)(e2.GetSalary() - e1.GetSalary()));

        foreach(Employee employee in employees)
        {
            if(employee.GetDepartment() == bestDepartment)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }

    private static string CalcDepartment(List<Employee> employees)
    {
        double bestAverage = -1;
        string bestDepartment = employees[0].GetDepartment();
        string currentDepartment;
        double currentAverage = 0;
        int temp = 0;
        foreach(Employee e in employees)
        {
            currentDepartment = e.GetDepartment();
            foreach(Employee e2 in employees)
            {
                if(e2.GetDepartment().Equals(currentDepartment))
                {
                    currentAverage += e2.GetSalary();
                    temp++;
                }
            }

            currentAverage /= temp;
            if(currentAverage > bestAverage)
            {
                bestAverage = currentAverage;
                bestDepartment = currentDepartment;
            }
            temp = 0;
            currentAverage = 0;
        }


        return bestDepartment;
    }

}

