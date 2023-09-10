internal class Program
{
    private static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Trim().Split(" ");
        
        int[] arr = new int[input.Length];

        for(int i = 0; i < arr.Length; i++)
        {
            
            arr[i] = int.Parse(input[i]);
        }

        int start = 0;
        int len = 1;
        int bestStart  = 0;
        int bestLen = len;

        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                len++;
            } else
            {
                if(len > bestLen)
                {
                bestLen = len;
                bestStart = start;
                }
                
                len = 1;
                start = i;
            }
        }
        if(len > bestLen )
        {
            bestLen = len;
        }
        for(int i = bestStart; i < bestStart + bestLen; i++) 
        {
            Console.Write(arr[i] + " ");
        }


    }
}