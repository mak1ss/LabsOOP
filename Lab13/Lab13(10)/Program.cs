internal class Program
{
    private static bool IsPolindrome(string text)
    {
        if (String.IsNullOrEmpty(text))
        {
            return false;
        }
        string reversed = new string(text.Reverse().ToArray());
        return text.Equals(reversed);
    }

    private static void Main(string[] args)
    {
        string input = Console.ReadLine();

        if (IsPolindrome(input))
        {
            Console.WriteLine(-1);
        }
        else
        {
            int res = -1;
            string withoutChar;
            for (int i = 0; i < input.Length; i++)
            {

                withoutChar = input.Remove(i, 1);
                if (IsPolindrome(withoutChar))
                {
                    res = i; break;
                }
            }

            Console.WriteLine(res);
        }
    }

}