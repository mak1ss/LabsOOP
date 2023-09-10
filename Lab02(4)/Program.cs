internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if( n < 2 )
        {
            Console.WriteLine("Input number is too small");
        }
        bool[] primes = new bool[n];
        for (int i = 0; i < primes.Length; i++)
        {
            primes[i] = true;
        }

        primes[0] = primes[1] = false;
        for(int i = 2; i < Math.Ceiling(Math.Sqrt(n)); i++)
        {
            if(primes[i])
            {
                int j = i * i;
                while(j < n)
                {
                    primes[j] = false;
                    j += i;
                }
            }
        }

        for (int i = 2; i < primes.Length; i++ )
        {
            if (primes[i]) 
            { 
                Console.Write(i + " ");
            }
            
        }

    }
}