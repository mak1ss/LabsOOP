using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string text = Console.ReadLine();

        char[] defaultSeparators = new char[17] { '.', ',', '!', '?', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '/', ' ', '\\' };
        string[] words = text.Split(defaultSeparators, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder stringBuilder = new StringBuilder();
        words.ToList().ForEach(w => stringBuilder.Append(w));   
        char[] letters = stringBuilder.ToString().ToCharArray();

        string[] separators = text.Split(letters, StringSplitOptions.RemoveEmptyEntries);

        words = words.Reverse().ToArray();
        for (int i = 0; i < words.Length; i++)
        {
            Console.Write(words[i] + separators[i]);
        }
    }
}