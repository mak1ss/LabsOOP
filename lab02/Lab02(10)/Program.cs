internal class Program
{
    private static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Trim().Split(" ");
        int diff = int.Parse(Console.ReadLine());

        int[] arr = new int[input.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(input[i]);
        }

        int pairs = 0;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for(int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] - arr[j] == diff || arr[j] - arr[i] == diff)
                {
                    pairs++;
                }
            }
        }
        Console.WriteLine(pairs);
    }
}