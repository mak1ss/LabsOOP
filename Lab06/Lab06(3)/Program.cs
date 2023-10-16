using Lab06;
internal class Program
{
    private static void Main(string[] args)
    {
        string[] studentInput = Console.ReadLine().Split(" ");
        string[] workerInput = Console.ReadLine().Split(" ");
        Student student = null;
        Worker worker = null;
        try
        {
            student = new Student(studentInput[0], studentInput[1], studentInput[2]);
            worker = new Worker(workerInput[0], workerInput[1], int.Parse(workerInput[2]), byte.Parse(workerInput[3]));
        } catch (ArgumentException ex)
        { 
            Console.WriteLine(ex.Message);
        }
        if(student != null && worker != null)
        {
            Console.WriteLine(student.ToString());
            Console.WriteLine(worker.ToString());

        }

    }
}