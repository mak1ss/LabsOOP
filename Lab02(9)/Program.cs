internal class Program
{
    private static void Main(string[] args)
    {
        char[] alphabet = new char[26];
        for(int i = 97, j = 0;  i <= 122; i++, j++)
        {
            alphabet[j] = (char)i;
        }

        string input = Console.ReadLine();
        for(int i = 0; i < input.Length; i ++)
        {
            for(int j = 0; j < alphabet.Length; j ++)
            {
                if (alphabet[j] == input[i])
                {
                    Console.WriteLine(input[i] + " -> " + j);
                }
            }
        }
    }
}