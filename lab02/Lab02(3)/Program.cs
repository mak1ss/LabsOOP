public class Program
{
    private static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(" ");
        int k = input.Length / 4;
        int[] upperArray = new int[input.Length / 2];
        for (int i = 0, j = k - 1, g = upperArray.Length - 1, f = input.Length - k; i < k; i++, j--, g--, f++)
        {
            upperArray[i] = int.Parse(input[j]);
            upperArray[g] = int.Parse(input[f]);
        }

        int[] lowerArray = new int[upperArray.Length];   
        for(int i = k, j = 0; i < input.Length - k; i++, j++)
        {
            lowerArray[j] = int.Parse(input[i]);
        }

        for(int i = 0; i < upperArray.Length; i++)
        {
            Console.Write(upperArray[i] + lowerArray[i] + " ");
        }
    }
}