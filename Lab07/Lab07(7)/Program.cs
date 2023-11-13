using Lab07_7_;

internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, IBuyer> customers = new Dictionary<string, IBuyer>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" ");
            if (customers.ContainsKey(input[0]))
            {
                continue;
            }
            try
            {
                customers.Add(input[0], new Human(input[0], int.Parse(input[1]), long.Parse(input[2]), input[3]));
            }
            catch (FormatException e)
            {
                customers.Add(input[0], new Rebel(input[0], input[2], int.Parse(input[1])));
            }
        }
        string name;
        while (!(name = Console.ReadLine()).Equals("End"))
        {
            if (customers.ContainsKey(name))
            {
                customers[name].BuyFood();
            }
        }
        int sum = 0;
        customers.Values.ToList().ForEach(c => sum += c.Food);
        Console.WriteLine(sum);
    }
}