using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int startIndex;
        int endIndex;
        while ((startIndex = input.IndexOf("<upcase>")) != -1)
        {
            endIndex = input.IndexOf("</upcase>");

            string upperReplacement =  input.Substring(startIndex + 8, endIndex - startIndex - 8).ToUpper();
            input = input.Replace(input.Substring(startIndex, endIndex + 9 - startIndex), upperReplacement);


        }
        Console.WriteLine(input);
    }
}