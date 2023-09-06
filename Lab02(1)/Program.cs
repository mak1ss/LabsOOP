public class Program
{
    public static void main(string[] args)
    {
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();
        string[] shorter;
        string[] longer;
        if (input1.Length < input2.Length)
        {
            shorter = input1.Split(" ");
            longer = input2.Split(" ");

        }
        else
        {
            shorter = input2.Split(" ");
            longer = input1.Split(" ");
        }


        int count = 0;

        for (int i = 0; i < shorter.Length; i++)
        {
            if (shorter[i].Equals(longer[i]))
            {
                count++;
            }
        }

        int countReverse = 0;
        for (int i = longer.Length - 1, j = shorter.Length - 1; j >= 0; i--, j--)
        {
            if (longer[i].Equals(shorter[j]))
            {
                countReverse++;
            }
        }

        Console.WriteLine(count > countReverse ? count : countReverse);
    }
}