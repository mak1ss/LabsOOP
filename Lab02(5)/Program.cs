

internal class Program
{
    private static void Main(string[] args)
    {
        char[] arr1 = Console.ReadLine().ToCharArray();
        char[] arr2 = Console.ReadLine().ToCharArray();
        
        
        int n = arr1.Length > arr2.Length ? arr2.Length : arr1.Length;
        bool equal = true;

            for(int i = 0; i < n; i++)
            {
                if (arr1[i] != 32 || arr2[i] != 32)
                {
                    if (arr1[i] != arr2[i])
                    {
                        equal = false;
                        if (arr1[i] < arr2[i])
                        {
                            Array.ForEach<char>(arr1, (e) => Console.Write(e));
                            Console.WriteLine();
                            Array.ForEach<char>(arr2, (e) => Console.Write(e));
                            break;
                        }
                        else
                        {
                            Array.ForEach<char>(arr2, (e) => Console.Write(e));
                            Console.WriteLine();
                            Array.ForEach<char>(arr1, (e) => Console.Write(e));
                            break;
                        }
                    }
                }
            }

        if (equal)
        {
            if(arr1.Length < arr2.Length)
            {
                Array.ForEach<char>(arr1, (e) => Console.Write(e));
                Console.WriteLine();
                Array.ForEach<char>(arr2, (e) => Console.Write(e));
            } else
            {
                Array.ForEach<char>(arr2, (e) => Console.Write(e));
                Console.WriteLine();
                Array.ForEach<char>(arr1, (e) => Console.Write(e));
            }
        }
        
    }
}