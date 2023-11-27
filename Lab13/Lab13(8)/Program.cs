using System.Collections.Generic;
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

        char[] defaultSeparators = new char[17] { '.', ',', '!', '?', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '/', ' ', '\\' };

        string[] words = input.Split(defaultSeparators, StringSplitOptions.RemoveEmptyEntries);
        SortedSet<string> polindromes = new SortedSet<string>();
        words.Where(IsPolindrome).ToList().ForEach(w => polindromes.Add(w));

        foreach (string word in polindromes)
        {
            Console.Write(word + " ");
        }
    }
}