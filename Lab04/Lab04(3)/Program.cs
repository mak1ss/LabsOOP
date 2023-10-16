internal class Program
{
    private static void Main(string[] args)
    {
        string[] inputDimensions = Console.ReadLine().Split(" ");

        int N = int.Parse(inputDimensions[0]);
        int M = int.Parse(inputDimensions[1]);

        int[,] sky = new int[N, M];
        int value = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                sky[i, j] = value;
                value++;
            }
        }
        string inputCoords;
        int ivoStars = 0;
        while (!(inputCoords = Console.ReadLine()).Equals("Let the Force be with you"))
        {
            string[] ivoCoords = inputCoords.Split(" ");
            int ivoRow = int.Parse(ivoCoords[0]) - 1;
            int ivoCol = int.Parse(ivoCoords[1]) - 1;

            int evilRow = ivoRow;
            int evilCol = M - ivoCol - 1;

            while (evilRow >= 0)
            {
                sky[evilRow, evilCol] = 0;
                evilRow--;
                evilCol--;
            }
            while (ivoRow >= 0)
            {
                ivoStars += sky[ivoRow, ivoCol];
                ivoRow--;
                ivoCol++;
            }            
        }
        Console.WriteLine(ivoStars);
    }
}