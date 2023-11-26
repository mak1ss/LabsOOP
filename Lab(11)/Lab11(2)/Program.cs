using Lab11_2_;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] names = Console.ReadLine().Split(" ");
        King king = new King(names[0]);

        names = Console.ReadLine().Split(" ");
        Dictionary<string, ISubordinate> map = new Dictionary<string, ISubordinate>();
        ISubordinate guard1 = new RoyalGuard(names[0], king);
        ISubordinate guard2 = new RoyalGuard(names[1], king);
        guard1.SubordinateKilled += king.OnSubordinateKilled;
        guard2.SubordinateKilled += king.OnSubordinateKilled;

        map.Add(names[0], guard1);
        map.Add(names[1], guard2);

        names = Console.ReadLine().Split(" ");
        ISubordinate footman;
        foreach (string name in names)
        {
            footman = new Footman(name, king);
            footman.SubordinateKilled += king.OnSubordinateKilled;
            map.Add(name, footman);
        }

        string input;
        while (!(input = Console.ReadLine()).Equals("End"))
        {
            string[] commands = input.Split(" ");
            if (commands[0].Equals("Attack")) 
            {
                if (!commands[1].Equals(king.Name))
                {
                    Console.WriteLine("Unknown king");
                    continue;
                }
                king.Attack();
            } else if(commands[0].Equals("Kill"))
            {
                if (!map.ContainsKey(commands[1]))
                {
                    Console.WriteLine("Unknown suborinate");
                    continue;
                }
                map[commands[1]].ReceiveHit();
            }
        }
    }
}