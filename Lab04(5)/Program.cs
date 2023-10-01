using Lab04;
internal class Program
{
    private static void Main(string[] args)
    {
        int bagCapacity = int.Parse(Console.ReadLine());
        Bag bag = new Bag(bagCapacity);
        string[] inputWealth = Console.ReadLine().Split(" ");
        for (int i = 0; i < inputWealth.Length; i += 2)
        {

            if (inputWealth[i].ToLower().Equals("gold"))
            {
                bag.addGold(new Gold(int.Parse(inputWealth[i + 1])));
            }
            else if (inputWealth[i].Length > 4 && inputWealth[i].ToLower().EndsWith("gem"))
            {
                bag.addGems(new Gem(int.Parse(inputWealth[i + 1]), inputWealth[i]));
            }
            else if (inputWealth[i].Length == 3)
            {
                bag.addCash(new Cash(int.Parse(inputWealth[i + 1]), inputWealth[i]));
            }
            else
            {
                Console.WriteLine("Unknown type of wealth: " + inputWealth[i]);
            }
        }
        Console.WriteLine(bag.ToString());
    }
}