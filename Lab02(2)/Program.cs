internal class Program
{
    private static void Main(string[] args)
    {
        string[] arrayInput = Console.ReadLine().Split(" ");

        int r = int.Parse(Console.ReadLine());

        int[] array = new int[arrayInput.Length];

        int[] sum = new int[arrayInput.Length];

        for (int i = 0; i < arrayInput.Length; i++)
        {
            array[i] = int.Parse(arrayInput[i]);
        }
        int temp;
        for (int i = 0; i < r; i++)
        {
            temp = array[array.Length - 1];
            for(int j = array.Length - 1; j > 0; j--)
            {
                array[j] = array[j - 1];
            }
            array[0] = temp;

            if (i >= 1)
            {
                for(int j = 0; j < array.Length; j++)
                {
                    sum[j] += array[j];
                }
            } else
            {
                for(int j = 0; j < array.Length; j++)
                {
                    sum[j] = array[j];
                }
            }
            
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(sum[i] + " ");
        }
    }
}