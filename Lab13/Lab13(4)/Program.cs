internal class Program
{
    private static void Main(string[] args)
    {
        string keyword = Console.ReadLine();
        string text = Console.ReadLine();

        string[] sentences = text.Split(new char[] { '.', '!', '?' });

        string[] cleanSentences = sentences;
        cleanSentences.ToList().ForEach(s => s.Select(c => Char.IsLetter(c) ? c : ' '));

        string[] sentence;
        for(int i = 0; i < cleanSentences.Length; i++)
        {
            sentence = cleanSentences[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (sentence.Where(w => w.Equals(keyword)).Any())
            {
                Console.WriteLine(sentences[i]);
            }
        }
    }
}