using System.Collections.Specialized;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, OrderedDictionary> stuff = new Dictionary<string, OrderedDictionary>();

        int n = int.Parse(Console.ReadLine());
        string[] input;
        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine().Split(" - ");
            if (stuff.ContainsKey(input[0]))
            {
                if (stuff[input[0]].Contains(input[2]))
                {
                    int oldQuantity = int.Parse((string)stuff[input[0]][input[2]]);
                    stuff[input[0]][input[2]] = int.Parse(input[1]) + oldQuantity; 
                }
                else
                {
                    stuff[input[0]].Add(input[2], input[1]);
                }
            }
            else
            {
                OrderedDictionary products = new OrderedDictionary();
                products.Add(input[2], input[1]);
                stuff.Add(input[0], products);
            }
        }

        foreach (KeyValuePair<string, OrderedDictionary> company in stuff.OrderBy(stuff => stuff.Key))
        {
            Console.Write(company.Key + ": ");

            foreach (var item in company.Value)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}