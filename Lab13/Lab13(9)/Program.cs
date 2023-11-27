using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        Console.WriteLine(textInfo.ToTitleCase(input));
    }
}