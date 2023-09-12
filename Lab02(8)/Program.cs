internal class Program
{
    private static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Trim().Split(" ");

        int[] arr = new int[input.Length];

        for (int i = 0; i < arr.Length; i++)
        {

            arr[i] = int.Parse(input[i]);
        }

        int mostFrequent = arr[0];
        int current;
        int count = 0;
        int bestCount = count;

        for(int i = 0; i < arr.Length ; i++)
        {
            current = arr[i];
            for(int j = 0; j < arr.Length ; j++)
            {
                if (arr[j] == current)
                {
                    count++;
                } 
                
                
            }
            if (count > bestCount)
            {
                bestCount = count;
                mostFrequent = current;
            }
            count = 0;
        }

        Console.WriteLine(mostFrequent);
    }
}