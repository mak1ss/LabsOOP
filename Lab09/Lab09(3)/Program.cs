using Lab09_3_;

internal class Program
{
    private static void Main(string[] args)
    {
        CustomStack<int> stack = new CustomStack<int>();
        string command;
        while (!(command = Console.ReadLine()).Equals("END"))
        {
            if (command.Contains("Push"))
            {
                for(int i = 1; i < command.Split(' ').Length; i++)
                {
                    stack.Push(i);
                }
            } else
            {
                stack.Pop();
            }
        }
        foreach (int i in stack)
        {
            Console.WriteLine(i);
        }
        foreach (int i in stack)
        {
            Console.WriteLine(i);
        }
    }
}